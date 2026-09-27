using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Model
{
    /// <summary>
    /// Бизнес-логика приложения. Содержит CRUD-операции и бизнес-функции.
    /// </summary>
    public class Logic
    {
        private readonly string dataFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
            "..", "..", "..", "..",
            "Model", "data", "robots.json");
        private readonly List<Robot> robots = new List<Robot>();

        /// <summary> Доступ к списку роботов только для чтения. </summary>
        public IReadOnlyList<Robot> Robots => robots;

        /// <summary> Следующий свободный ID (максимальный + 1). </summary>
        public int NextId => robots.Count == 0 ? 1 : robots.Max(r => r.Id) + 1;

        /// <summary>
        /// Добавляет нового робота. ID присваивается автоматически.
        /// </summary>
        /// <param name="robot"> Экземпляр робота (поле Id игнорируется). </param>
        /// <returns> Присвоенный ID. </returns>
        public int Add(Robot robot)
        {
            robot.Id = NextId;
            robots.Add(robot);
            return robot.Id;
        }

        /// <summary>
        /// Возвращает робота по его ID.
        /// </summary>
        /// <param name="id"> Идентификатор робота. </param>
        /// <returns> Робот с указанным ID или null, если не найден. </returns>
        public Robot? GetById(int id) => robots.FirstOrDefault(r => r.Id == id);

        /// <summary>
        /// Возвращает копию списка всех роботов.
        /// </summary>
        /// <returns> Копия списка всех роботов. </returns>
        public List<Robot> GetAll() => robots.ToList();

        /// <summary>
        /// Изменяет робота с указанным Id.
        /// Внутри change выполняется ровно одна правка.
        /// </summary>
        /// <param name="id"> Ключ робота (Id). </param>
        /// <param name="change"> Делегат, который что-то меняет в найденном роботе. </param>
        /// <returns> true - если робот найден и правка применена; иначе false. </returns>
        /// <exception cref="ArgumentNullException"> Если change равен null. </exception>
        public bool Update(int id, Action<Robot> change)
        {
            if (change == null)
            { 
                throw new ArgumentNullException(nameof(change));           
            }

            var r = GetById(id);
            if (r == null) 
            { 
                return false;
            }

            change(r);
            return true;
        }

        /// <summary>
        /// Удаляет робота по ID.
        /// </summary>
        /// <param name="id"> Идентификатор робота. </param>
        /// <returns> true, если робот был удалён; иначе false. </returns>
        public bool Delete(int id) => robots.RemoveAll(r => r.Id == id) > 0;

        /// <summary>
        /// Бизнес-функция #1: группирует роботов по типу.
        /// </summary>
        /// <returns> Словарь, где ключ — тип, значение — список роботов. </returns>
        public Dictionary<string, List<Robot>> GroupByType()
            => robots.GroupBy(r => r.Type).ToDictionary(g => g.Key, g => g.ToList());

        /// <summary>
        /// Бизнес-функция #2: вычисляет среднюю цену по каждой серии.
        /// </summary>
        /// <returns> Словарь, где ключ — серия, значение — средняя цена. </returns>
        public Dictionary<string, decimal> AveragePriceBySeries()
            => robots.GroupBy(r => r.Series).ToDictionary(g => g.Key, g => g.Average(r => r.PriceRub));

        /// <summary>
        /// Сохраняет коллекцию роботов в JSON-файл.
        /// </summary>
        public void Save()
        {
            var json = JsonSerializer.Serialize(robots, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(dataFile, json);
        }

        /// <summary>
        /// Загружает роботов из JSON-файла, если он существует.
        /// </summary>
        public void Load()
        {
            if (!File.Exists(dataFile)) 
            { 
                return; 
            }

            var json = File.ReadAllText(dataFile);
            var loaded = JsonSerializer.Deserialize<List<Robot>>(json);

            if (loaded != null)
            {
                robots.Clear();
                robots.AddRange(loaded);
            }
        }
    }
}
