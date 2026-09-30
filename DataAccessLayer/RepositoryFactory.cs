using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    /// <summary>
    /// Тип источника данных, между которыми можно переключаться во время работы.
    /// </summary>
    public enum DataSourceKind
    {
        Json,
        Dapper,
        EntityFramework
    }

    /// <summary>
    /// Единственная публичная точка входа в DAL.
    /// Знает: строку подключения к БД, путь к JSON-файлу,
    /// как создать нужный репозиторий.
    /// </summary>
    public static class RepositoryFactory
    {
        /// <summary>
        /// Строка подключения к LocalDB.
        /// </summary>
        private const string ConnectionString = 
            @"Data Source=(LocalDB)\MSSQLLocalDB;" + 
            @"Initial Catalog=RobotsDb;" +
            @"Integrated Security=True";
        
        /// <summary>
        /// Путь к .json
        /// </summary>
        /// <returns> Строку расположения </returns>
        public static string RobotsJsonPath()
        {
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var solutionRoot = Path.GetFullPath(Path.Combine(baseDir, "..", "..", "..", ".."));
            return Path.Combine(solutionRoot, "Model", "data", "robots.json");
        }

        /// <summary>
        /// Создаёт репозиторий указанного типа для доменного объекта Robot.
        /// </summary>
        /// <typeparam name="T"> Доменный объект </typeparam>
        /// <param name="kind"> Какой источник использовать. </param>
        /// <returns> Экземпляр IRepository, готовый к CRUD-операциям над Robot. </returns>
        /// <exception cref="ArgumentOutOfRangeException"> 
        /// Возникает, если в kind передано значение, не входящее в DataSourceKind
        /// (например, результат некорректного приведения (DataSourceKind)99). 
        /// </exception>
        public static IRepository<Robot> Create(DataSourceKind kind)
        {
            return kind switch
            {
                DataSourceKind.Json => new JsonRepository(RobotsJsonPath()),
                DataSourceKind.Dapper => new DapperRepository(ConnectionString),
                DataSourceKind.EntityFramework => new EntityRepository(new DataContext(ConnectionString)),
                _ => throw new ArgumentOutOfRangeException(nameof(kind), kind, null)
            };
        }

    }
}
