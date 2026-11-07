using DataAccessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLogic.Interfaces
{
    /// <summary>
    /// Общий интерфейс бизнес-логики (Фасад)
    /// Объединяет все обязанности
    /// </summary>
    public interface ILogic : IOperationsCRUD, IGroupByTypeFunction, IAveragePriceFunction
    {
        /// <summary>
        /// Заменяет источник данных во всех компонентах
        /// </summary>
        /// <param name="repository"> Новый репазиторий </param>
        void SetRepository(IRepository<Robot> repository);
    }
}
