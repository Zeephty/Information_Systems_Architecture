using Dapper;
using Microsoft.Data.SqlClient;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    /// <summary>
    /// Dapper-реализация
    /// </summary>
    public class DapperRepository : IRepository<Robot>
    {
        private readonly string connectionString;

        /// <summary>
        /// Создаёт репозиторий с указанной строкой подключения.
        /// </summary>
        /// <param name="connectionString"> Строка подключения к SQL Server. </param>
        /// <exception cref="ArgumentNullException"> Если строка null. </exception>
        public DapperRepository(string connectionString) => this.connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));

        /// <summary>
        /// Открывает соединение, выполняет действие, возвращает результат
        /// и гарантированно закрывает соединение в блоке finally.
        /// </summary>
        /// <typeparam name="TResult"> Тип возвращаемого значения. </typeparam>
        /// <param name="action"> Действие, выполняемое с открытым соединением. </param>
        private TResult WithConnection<TResult>(Func<IDbConnection, TResult> action)
        {
            IDbConnection db = new SqlConnection(connectionString);
            try
            {
                db.Open();
                return action(db);
            }
            finally
            {
                // Отключение от источника данных
                db?.Dispose();
            }
        }

        /// <summary>
        /// То же, что и обобщённая версия, но для действий без возврата.
        /// </summary>
        /// <param name="action"> Действие с открытым соединением. </param>
        private void WithConnection(Action<IDbConnection> action)
        {
            IDbConnection db = new SqlConnection(connectionString);
            try
            {
                db.Open();
                action(db);
            }
            finally
            {
                db?.Dispose();
            }
        }

        /// <summary>
        /// Добавляет нового робота: создаёт записи в справочниках (если нужно),
        /// вставляет строку в Robots и связи в RobotCriteria
        /// </summary>
        /// <param name="r"> Добавляемая сущность </param>
        public void Create(Robot r)
            => WithConnection(db =>
            {
                int seriesId = GetOrCreateId(db, "Series", r.Series);
                int typeId = GetOrCreateId(db, "Types", r.Type);

                int newId = db.ExecuteScalar<int>(
                    @"INSERT INTO Robots
                              (Number, SeriesId, TypeId, Name, Goal, Details, Appearance, PriceRub)
                          VALUES
                              (@Number, @SeriesId, @TypeId, @Name, @Goal, @Details, @Appearance, @PriceRub);
                          SELECT CAST(SCOPE_IDENTITY() AS INT);",
                    new
                    {
                        r.Number,
                        SeriesId = seriesId,
                        TypeId = typeId,
                        r.Name,
                        r.Goal,
                        r.Details,
                        r.Appearance,
                        r.PriceRub
                    });

                r.Id = newId;

                foreach (var code in r.CriteriaCodes.Distinct())
                {
                    db.Execute(
                        "INSERT INTO RobotCriteria (RobotId, CriterionCode) VALUES (@RobotId, @Code)",
                        new { RobotId = newId, Code = code });
                }
            });

        /// <summary>
        /// Обновляет робота: справочники, строку в Robots
        /// </summary>
        /// <param name="r"> Редактируемая сущность </param>
        public void Update(Robot r)
            => WithConnection(db =>
            {
                int seriesId = GetOrCreateId(db, "Series", r.Series);
                int typeId = GetOrCreateId(db, "Types", r.Type);

                db.Execute(
                    @"UPDATE Robots SET
                          Number     = @Number,
                          SeriesId   = @SeriesId,
                          TypeId     = @TypeId,
                          Name       = @Name,
                          Goal       = @Goal,
                          Details    = @Details,
                          Appearance = @Appearance,
                          PriceRub   = @PriceRub
                      WHERE Id = @Id;",
                    new
                    {
                        r.Id,
                        r.Number,
                        SeriesId = seriesId,
                        TypeId = typeId,
                        r.Name,
                        r.Goal,
                        r.Details,
                        r.Appearance,
                        r.PriceRub
                    });

                db.Execute("DELETE FROM RobotCriteria WHERE RobotId = @Id", new { r.Id });

                foreach (var code in r.CriteriaCodes.Distinct())
                {
                    db.Execute(
                        "INSERT INTO RobotCriteria (RobotId, CriterionCode) VALUES (@RobotId, @Code)",
                        new { RobotId = r.Id, Code = code });
                }
            });

        /// <summary>
        /// Удаляет робота и связанные строки в RobotCriteria.
        /// </summary>
        /// <param name="r"> Удаляемая сущность </param>
        public void Delete(Robot r)
            => WithConnection(db =>
            {
                db.Execute("DELETE FROM RobotCriteria WHERE RobotId = @Id", new { r.Id });
                db.Execute("DELETE FROM Robots        WHERE Id      = @Id", new { r.Id });
            });

        /// <summary>
        /// Читает одного робота по Id (JOIN со справочниками + отдельный запрос за критериями)
        /// </summary>
        /// <param name="id"> Id робота </param>
        /// <returns> Возращает робота </returns>
        public Robot? ReadById(int id)
            => WithConnection(db =>
            {
                // Алиасы колонок совпадают с именами свойств Robot → Dapper маппит сам
                var robot = db.QuerySingleOrDefault<Robot>(
                    @"SELECT r.Id, r.Number,
                             s.Name AS Series,
                             t.Name AS Type,
                             r.Name, r.Goal, r.Details, r.Appearance, r.PriceRub
                      FROM Robots r
                      JOIN Series s ON s.Id = r.SeriesId
                      JOIN Types  t ON t.Id = r.TypeId
                      WHERE r.Id = @Id;",
                    new { Id = id });

                if (robot == null) return null;

                robot.CriteriaCodes = db.Query<int>(
                    "SELECT CriterionCode FROM RobotCriteria WHERE RobotId = @Id",
                    new { Id = id }).ToList();

                return robot;
            });

        /// <summary>
        /// Читает всех роботов с подгрузкой критериев.
        /// </summary>
        /// <returns> Список всех роботов </returns>
        public IEnumerable<Robot> ReadAll()
            => WithConnection(db =>
            {
                var robots = db.Query<Robot>(
                    @"SELECT r.Id, r.Number,
                             s.Name AS Series,
                             t.Name AS Type,
                             r.Name, r.Goal, r.Details, r.Appearance, r.PriceRub
                      FROM Robots r
                      JOIN Series s ON s.Id = r.SeriesId
                      JOIN Types  t ON t.Id = r.TypeId
                      ORDER BY r.Id;").ToList();

                // N+1 — для лабы достаточно; в проде — QueryMultiple
                foreach (var r in robots)
                {
                    r.CriteriaCodes = db.Query<int>(
                        "SELECT CriterionCode FROM RobotCriteria WHERE RobotId = @Id",
                        new { Id = r.Id }).ToList();
                }

                return robots;
            });

        /// <summary>
        /// Возвращает Id записи из таблицы-справочника по имени,
        /// либо создаёт новую и возвращает её Id.
        /// </summary>
        /// <param name="db"> Открытое соединение </param>
        /// <param name="table"> Имя таблицы справочника(Series / Types) </param>
        /// <param name="name"> Название записи </param>
        /// <returns> Возращает Id </returns>
        private static int GetOrCreateId(IDbConnection db, string table, string name)
        {
            var id = db.QuerySingleOrDefault<int?>(
                $"SELECT Id FROM {table} WHERE Name = @Name",
                new { Name = name });

            if (id.HasValue)
            {
                return id.Value;
            }

            return db.ExecuteScalar<int>(
                $"INSERT INTO {table} (Name) VALUES (@Name); " +
                "SELECT CAST(SCOPE_IDENTITY() AS INT);",
                new { Name = name });
        }           
    }
}
