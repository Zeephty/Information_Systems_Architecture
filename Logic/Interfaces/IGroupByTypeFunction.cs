using DataAccessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLogic.Interfaces
{
    /// <summary>
    /// Бизнес-функция: группирует роботов по типу.
    /// </summary>
    public interface IGroupByTypeFunction
    {
        /// <summary>
        /// Бизнес-функция #1: группирует роботов по типу.
        /// </summary>
        /// <returns> Словарь, где ключ — тип, значение — список роботов. </returns>
        Dictionary<string, List<Robot>> GroupByType();
    }
}
