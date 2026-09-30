using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace DataAccessLayer
{
    /// <summary>
    /// JSON-репозиторий. Хранит список доменных объектов в одном файле.
    /// Путь к файлу передаётся снаружи
    /// </summary>
    public class JsonRepository : IRepository<Robot>
    {
        private readonly string filePath;
        private readonly JsonSerializerOptions options = new() { WriteIndented = true };

        /// <summary>
        /// Создаёт репозиторий для указанного файла.
        /// Если файла нет — создаёт пустой JSON-массив.
        /// </summary>
        /// <param name="filePath"> Абсолютный путь к JSON-файлу. </param>
        /// <exception cref="ArgumentNullException"> Если путь null. </exception>
        public JsonRepository(string filePath)
        {
            this.filePath = filePath ?? throw new ArgumentNullException(nameof(filePath));
            EnsureFile();
        }

        /// <summary>
        /// Проверяет существование каталога и файла, при необходимости создаёт их.
        /// </summary>
        private void EnsureFile()
        {
            var dir = Path.GetDirectoryName(filePath);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "[]");
            }
        }

        /// <summary>
        /// Читает весь файл и десериализует в список.
        /// При отсутствии файла возвращает пустой список.
        /// </summary>
        /// <returns> Список </returns>
        private List<Robot> Load()
        {
            if (!File.Exists(filePath))
            {
                return new List<Robot>();
            }

            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Robot>>(json) ?? new List<Robot>();
        }

        /// <summary>
        /// Сериализует список в JSON и перезаписывает файл.
        /// </summary>
        /// <param name="items"> Список объектов </param>
        private void Save(List<Robot> items)
        {
            var json = JsonSerializer.Serialize(items, options);

            FileStream? fs = null;
            try
            {
                fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                using var writer = new StreamWriter(fs);
                writer.Write(json);
            }
            finally
            {
                fs?.Dispose();
            }
        }

        /// <summary>
        /// Добавляет нового робота. Id присваивается как max(Id)+1.
        /// </summary>
        /// <param name="obj"> Робот добавляемый </param>
        public void Create(Robot obj)
        {
            var list = Load();

            // JSON не умеет IDENTITY — выдаём Id сами
            obj.Id = list.Count == 0 ? 1 : list.Max(x => x.Id) + 1;
            list.Add(obj);
            Save(list);
        }

        /// <summary>
        /// Заменяет запись с тем же Id.
        /// Если записи нет — ничего не делает.
        /// </summary>
        /// <param name="obj"> Изменяемый робот </param>
        public void Update(Robot obj)
        {
            var list = Load();
            var idx = list.FindIndex(x => x.Id == obj.Id);
            if (idx < 0)
            {
                return;
            }
            list[idx] = obj;
            Save(list);
        }

        /// <summary>
        /// Удаляет запись по Id.
        /// </summary>
        /// <param name="obj"> Удаляемый робот </param>
        public void Delete(Robot obj)
        {
            var list = Load();
            list.RemoveAll(x => x.Id == obj.Id);
            Save(list);
        }

        /// <summary>
        /// Возращает запись по Id
        /// </summary>
        /// <param name="id"> Id робота </param>
        /// <returns> Запись по Id или null. </returns>
        public Robot? ReadById(int id) => Load().FirstOrDefault(x => x.Id == id);

        /// <summary>
        /// Возращает все записи
        /// </summary>
        /// <returns> Все записи. </returns>
        public IEnumerable<Robot> ReadAll() => Load();
    }
}
