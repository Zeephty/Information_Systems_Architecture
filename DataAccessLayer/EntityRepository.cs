using DataAccessLayer.Persistence;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    /// <summary>
    /// EF-реализация
    /// </summary>
    public class EntityRepository : IRepository<Robot>
    {
        private readonly DataContext context;

        /// <summary>
        /// Создаёт репозиторий поверх переданного EF-контекста.
        /// </summary>
        /// <param name="context"> Контекст БД </param>
        /// <exception cref="ArgumentNullException"> Если context null. </exception>
        public EntityRepository(DataContext context) => this.context = context ?? throw new ArgumentNullException(nameof(context));

        /// <summary>
        /// Добавляет нового робота в БД. Id заполняется автоматически и возвращается в объект.
        /// </summary>
        /// <param name="r"> Объект робота </param>
        public void Create(Robot r)
        {
            var series = GetOrCreateSeries(r.Series);
            var type = GetOrCreateType(r.Type);

            var row = new RobotRow
            {
                Number = r.Number,
                SeriesId = series.Id,
                TypeId = type.Id,
                Name = r.Name,
                Goal = r.Goal,
                Details = r.Details,
                Appearance = r.Appearance,
                PriceRub = r.PriceRub,
                Criteria = r.CriteriaCodes
                    .Distinct()
                    .OrderBy(c => c)
                    .Select(c => new RobotCriterionRow { CriterionCode = c })
                    .ToList()
            };

            context.Robots.Add(row);
            context.SaveChanges(); // IDENTITY заполнит row.Id
            r.Id = row.Id; // возвращаем Id в домен
        }

        /// <summary>
        /// Обновляет существующего робота (включая связи с критериями)
        /// </summary>
        /// <param name="r"> Объект робота </param>
        public void Update(Robot r)
        {
            var row = context.Robots
                .Include(x => x.Criteria)
                .FirstOrDefault(x => x.Id == r.Id);
            if (row == null)
            {
                return;
            }

            var series = GetOrCreateSeries(r.Series);
            var type = GetOrCreateType(r.Type);

            row.Number = r.Number;
            row.SeriesId = series.Id;
            row.TypeId = type.Id;
            row.Name = r.Name;
            row.Goal = r.Goal;
            row.Details = r.Details;
            row.Appearance = r.Appearance;
            row.PriceRub = r.PriceRub;

            // Пересобираем с нуля
            context.RobotCriteria.RemoveRange(row.Criteria);
            row.Criteria = r.CriteriaCodes
                .Distinct()
                .OrderBy(c => c)
                .Select(c => new RobotCriterionRow
                {
                    RobotId = row.Id,
                    CriterionCode = c
                })
                .ToList();

            context.SaveChanges();
        }

        /// <summary>
        /// Удаляет робота. Связанные записи в <c>RobotCriteria</c> удаляются каскадом.
        /// </summary>
        /// <param name="r"> Обект робота </param>
        public void Delete(Robot r)
        {
            var row = context.Robots.FirstOrDefault(x => x.Id == r.Id);
            if (row == null)
            {
                return;
            }

            context.Robots.Remove(row); // Cascade снесёт RobotCriteria
            context.SaveChanges();
        }

        /// <summary>
        /// Возвращает робота по Id или null.
        /// </summary>
        /// <param name="id"> Id робота </param>
        /// <returns> Робот или null </returns>
        public Robot? ReadById(int id)
        {
            var row = context.Robots
                .AsNoTracking()
                .Include(x => x.Series)
                .Include(x => x.Type)
                .Include(x => x.Criteria)
                .FirstOrDefault(x => x.Id == id);

            return row == null ? null : ToDomain(row);
        }

        /// <summary>
        /// Возвращает всех роботов с подгруженными справочниками и критериями.
        /// </summary>
        /// <returns> Список всех роботов </returns>
        public IEnumerable<Robot> ReadAll()
        {
            var rows = context.Robots
                .AsNoTracking()
                .Include(x => x.Series)
                .Include(x => x.Type)
                .Include(x => x.Criteria)
                .ToList();

            return rows.Select(ToDomain).ToList();
        }

        // =============== Справочники ===============

        /// <summary>
        /// Находит серию по имени или создаёт новую. Возвращает строку справочника.
        /// </summary>
        /// <param name="name"> Имя </param>
        /// <returns> Серию </returns>
        private SeriesRow GetOrCreateSeries(string name)
        {
            var row = context.Series.FirstOrDefault(x => x.Name == name);
            if (row != null)
            {
                return row;
            }

            row = new SeriesRow { Name = name };
            context.Series.Add(row);
            context.SaveChanges();
            return row;
        }

        /// <summary>
        /// Находит тип по имени или создаёт новый. Возвращает строку справочника.
        /// </summary>
        /// <param name="name"> Имя </param>
        /// <returns> Тип </returns>
        private TypeRow GetOrCreateType(string name)
        {
            var row = context.Types.FirstOrDefault(x => x.Name == name);
            if (row != null) return row;

            row = new TypeRow { Name = name };
            context.Types.Add(row);
            context.SaveChanges();
            return row;
        }

        // =============== Маппинг persistence -> домен ===============

        /// <summary>
        /// Преобразует строку RobotRow в доменный Robot.
        /// Собирает плоскую модель из нормализованных таблиц.
        /// </summary>
        /// <param name="row"> Строка </param>
        /// <returns> Объект робота </returns>
        private static Robot ToDomain(RobotRow row) => new Robot
        {
            Id = row.Id,
            Number = row.Number,
            Series = row.Series?.Name ?? "",
            Type = row.Type?.Name ?? "",
            Name = row.Name,
            Goal = row.Goal,
            Details = row.Details,
            Appearance = row.Appearance,
            PriceRub = row.PriceRub,
            CriteriaCodes = row.Criteria
                .Select(c => c.CriterionCode)
                .OrderBy(c => c)
                .ToList()
        };
    }
}
