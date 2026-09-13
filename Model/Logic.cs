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
        private readonly string dataFile = Path.Combine("robots.json");
        private readonly List<Robot> robots = new List<Robot>();

        /// <summary> Доступ к списку роботов только для чтения. </summary>
        public IReadOnlyList<Robot> Robots => robots;

        /// <summary>
        /// Добавляет нового робота в коллекцию.
        /// </summary>
        /// <param name="robot"> Экземпляр добовляемого робота. </param>
        /// <exception cref="ArgumentException"> Если ID пуст. </exception>
        /// <exception cref="InvalidOperationException"> Если робот с таким ID уже существует. </exception>
        public void Add(Robot robot)
        {
            if (string.IsNullOrWhiteSpace(robot.Name))
            {
                throw new ArgumentException("ID обязателен");
            }
            if (robots.Any(r => r.Id == robot.Id))
            {
                throw new InvalidOperationException($"Робот с ID {robot.Id} уже существует");
            }

            robots.Add(robot);
        }

        /// <summary>
        /// Возвращает робота по его ID.
        /// </summary>
        /// <param name="id"> Идентификатор робота. </param>
        /// <returns> Робот с указанным ID или null, если не найден. </returns>
        public Robot? GetById(string id) => robots.FirstOrDefault(r => r.Id == id);

        /// <summary>
        /// Возвращает копию списка всех роботов.
        /// </summary>
        /// <returns> Копия списка всех роботов. </returns>
        public List<Robot> GetAll() => robots.ToList();

        /// <summary>
        /// Обновляет существующего робота.
        /// </summary>
        /// <param name="updated"> Робот с новыми данными (ID должен совпадать). </param>
        /// <exception cref="InvalidOperationException"> Если робот с таким ID не найден. </exception>
        public void Update(Robot updated)
        {
            var existing = GetById(updated.Id) 
                ?? throw new InvalidOperationException($"Робот с ID {updated.Id} не найден");

            existing.Number = updated.Number;
            existing.Series = updated.Series;
            existing.Type = updated.Type;
            existing.Name = updated.Name;
            existing.Goal = updated.Goal;
            existing.Details = updated.Details;
            existing.Appearance = updated.Appearance;
            existing.Score = updated.Score;
            existing.CriteriaCodes = new List<int>(updated.CriteriaCodes);
            existing.PriceRub = updated.PriceRub;
        }

        /// <summary>
        /// Удаляет робота по ID.
        /// </summary>
        /// <param name="id"> Идентификатор робота. </param>
        /// <returns> true, если робот был удалён; иначе false. </returns>
        public bool Delete(string id) => robots.RemoveAll(r => r.Id == id) > 0;

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
