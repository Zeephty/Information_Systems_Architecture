using BLogic.Interfaces;
using BLogic.Realization;
using DataAccessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLogic
{
    /// <summary>
    /// Новая реализация бизнес-логики.
    /// Реализует общий интерфейс ILogic (фасад).
    /// </summary>
    public class Logic2 : ILogic
    {
        private readonly IOperationsCRUD operationsCRUD;
        private readonly IGroupByTypeFunction groupByType;
        private readonly IAveragePriceFunction averagePrice;
        private readonly RepositoryProvider provider;

        /// <summary>
        /// Создаёт фасад с внедрёнными компонентами.
        /// </summary>
        /// <param name="operationsCRUD"> Компонент CRUD-операций. </param>
        /// <param name="groupByType"> Бизнес-функция группировки по типу. </param>
        /// <param name="averagePrice"> Бизнес-функция средней цены. </param>
        /// <param name="provider"> Система с актуальным репозиторием. </param
        /// <exception cref="ArgumentNullException"> Если любой из аргументов равен null </exception>
        public Logic2(IOperationsCRUD operationsCRUD, IGroupByTypeFunction groupByType, IAveragePriceFunction averagePrice, RepositoryProvider provider)
        {
            this.operationsCRUD = operationsCRUD ?? throw new ArgumentNullException(nameof(operationsCRUD));
            this.groupByType = groupByType ?? throw new ArgumentNullException(nameof(groupByType));
            this.averagePrice = averagePrice ?? throw new ArgumentNullException(nameof(averagePrice));
            this.provider = provider ?? throw new ArgumentNullException(nameof(provider));
        }

        /// <summary>
        /// Обновляет репозиторий во всех трёх обязанностях.
        /// </summary>
        /// <param name="repository"> Новый репозиторий </param>
        public void SetRepository(IRepository<Robot> repository)
        {
            provider.SetRepository(repository);
        }

        /// <summary>
        /// Добавить сущность в хранилище
        /// </summary>
        /// <param name="robot"> Сущность </param>
        public void Add(Robot robot) => operationsCRUD.Add(robot);

        /// <summary>
        /// Получаем по ID сущность
        /// </summary>
        /// <param name="id"> ID сущности </param>
        /// <returns> Возвращение сущности </returns>
        public Robot? GetById(int id) => operationsCRUD.GetById(id);

        /// <summary>
        /// Получить все сущности
        /// </summary>
        /// <returns> Все сущности </returns>
        public List<Robot> GetAll() => operationsCRUD.GetAll();

        /// <summary>
        /// Обновить сущность
        /// </summary>
        /// <param name="robot"> Новая сущность </param>
        public void Update(Robot robot) => operationsCRUD.Update(robot);

        /// <summary>
        /// Удалить сущность
        /// </summary>
        /// <param name="robot"> Удаляемая сущность </param>
        public void Delete(Robot robot) => operationsCRUD.Delete(robot);

        /// <summary>
        /// Бизнес-функция: группирует роботов по типу.
        /// </summary>
        /// <returns> Словарь, где ключ — тип, значение — список роботов. </returns>
        public Dictionary<string, List<Robot>> GroupByType() => groupByType.GroupByType();

        /// <summary>
        /// Возвращает словарь: ключ — тип, значение — список роботов этого типа.
        /// </summary>
        /// <returns> Словарь со средней ценой. </returns>
        public Dictionary<string, decimal> AveragePriceBySeries() => averagePrice.AveragePriceBySeries();
    }
}
