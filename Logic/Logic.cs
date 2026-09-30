using DataAccessLayer;
using Model;

namespace BLogic
{
    /// <summary>
    /// Бизнес-логика приложения. Содержит CRUD-операции и бизнес-функции.
    /// </summary>
    public class Logic
    {
        private IRepository<Robot> repository;

        /// <summary>
        /// Создаёт бизнес-логику с указанным источником данных.
        /// </summary>
        /// <param name="repository"> Репозиторий для доступа к данным. </param>
        /// <exception cref="ArgumentNullException"> Если repository равен null. </exception>
        public Logic(IRepository<Robot> repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        /// <summary>
        /// Заменяет текущий источник данных. Используется для смены репозитория
        /// </summary>
        /// <param name="newRepository"> Новый репозиторий для доступа к данным. </param>
        /// <exception cref="ArgumentNullException"> Если newRepository равен null. </exception>
        public void SetRepository(IRepository<Robot> newRepository)
        {
            this.repository = newRepository ?? throw new ArgumentNullException(nameof(newRepository));
        }

        /// <summary>
        /// Добавляет робота в источник данных. Идентификатор присваивает репозиторий.
        /// </summary>
        /// <param name="robot"> Экземпляр робота </param>
        public void Add(Robot robot) => repository.Create(robot);

        /// <summary>
        /// Возвращает робота по его идентификатору.
        /// </summary>
        /// <param name="id"> Идентификатор робота. </param>
        /// <returns> Робот с указанным Id или null, если не найден. </returns>
        public Robot? GetById(int id) => repository.ReadById(id);

        /// <summary>
        /// Возвращает список всех роботов из источника данных.
        /// </summary>
        /// <returns> Копия списка всех роботов. </returns>
        public List<Robot> GetAll() => repository.ReadAll().ToList();

        /// <summary>
        /// Обновляет существующего робота. Сопоставление идёт по полю Id.
        /// </summary>
        /// <param name="robot"> Робот с новыми значениями полей. </param>
        public void Update(Robot robot) => repository.Update(robot);

        /// <summary>
        /// Удаляет робота из источника данных. Сопоставление идёт по полю Id.
        /// </summary>
        /// <param name="robot"> Удаляемый робот. </param>
        public void Delete(Robot robot) => repository.Delete(robot);

        /// <summary>
        /// Бизнес-функция #1: группирует роботов по типу.
        /// </summary>
        /// <returns> Словарь, где ключ — тип, значение — список роботов. </returns>
        public Dictionary<string, List<Robot>> GroupByType()
            => repository.ReadAll().GroupBy(r => r.Type).ToDictionary(g => g.Key, g => g.ToList());

        /// <summary>
        /// Бизнес-функция #2: вычисляет среднюю цену по каждой серии.
        /// </summary>
        /// <returns> Словарь, где ключ — серия, значение — средняя цена. </returns>
        public Dictionary<string, decimal> AveragePriceBySeries()
            => repository.ReadAll().GroupBy(r => r.Series).ToDictionary(g => g.Key, g => g.Average(r => r.PriceRub));
    }
}
