using BLogic.Interfaces;
using DataAccessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLogic
{
    public class ObservableLogicDecorator : IObservableLogic
    {
        private readonly ILogic logic;

        /// <summary>
        /// Событие ихменнения данных
        /// </summary>
        public event Action? DataChanged;

        /// <summary>
        /// Конструктор декоратора логики 
        /// </summary>
        /// <param name="logic"> существующая логика </param>
        /// <exception cref="ArgumentNullException"> Если Null </exception>
        public ObservableLogicDecorator(ILogic logic)
        {
            this.logic = logic ?? throw new ArgumentNullException(nameof(logic));
        }

        /// <summary>
        /// Добавить сущность в хранилище
        /// </summary>
        /// <param name="robot"> Сущность </param>
        public void Add(Robot robot)
        {
            logic.Add(robot);
            DataChanged?.Invoke();
        }

        /// <summary>
        /// Обновить сущность
        /// </summary>
        /// <param name="robot"> Новая сущность </param>
        public void Update(Robot robot)
        {
            logic.Update(robot);
            DataChanged?.Invoke();
        }

        /// <summary>
        /// Удалить сущность
        /// </summary>
        /// <param name="robot"> Удаляемая сущность </param>
        public void Delete(Robot robot)
        {
            logic.Delete(robot);
            DataChanged?.Invoke();
        }

        /// <summary>
        /// Обновляет репозиторий во всех трёх обязанностях.
        /// </summary>
        /// <param name="repository"> Новый репозиторий </param>
        public void SetRepository(IRepository<Robot> repository)
        {
            logic.SetRepository(repository);
            DataChanged?.Invoke();
        }

        /// <summary>
        /// Получаем по ID сущность
        /// </summary>
        /// <param name="id"> ID сущности </param>
        /// <returns> Возвращение сущности </returns>
        public Robot? GetById(int id) => logic.GetById(id);

        /// <summary>
        /// Получить все сущности
        /// </summary>
        /// <returns> Все сущности </returns>
        public List<Robot> GetAll() => logic.GetAll();

        /// <summary>
        /// Бизнес-функция: использует группировку роботов по типу. 
        /// </summary>
        /// <returns> Словарь, где ключ — тип, значение — список роботов. </returns>
        public Dictionary<string, List<Robot>> GroupByType() => logic.GroupByType();

        /// <summary>
        /// Возвращает словарь: ключ — тип, значение — список роботов этого типа.
        /// </summary>
        /// <returns> Словарь со средней ценой. </returns>
        public Dictionary<string, decimal> AveragePriceBySeries() => logic.AveragePriceBySeries();

    }
}
