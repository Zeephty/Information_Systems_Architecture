using DataAccessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLogic.Interfaces
{
    /// <summary>
    /// Бизнес-функция: вычисляет среднюю цену по каждой серии.
    /// </summary>
    public interface IAveragePriceFunction
    {
        /// <summary>
        /// Бизнес-функция: вычисляет среднюю цену по каждой серии.
        /// </summary>
        /// <returns> Словарь, где ключ — серия, значение — средняя цена. </returns>
        Dictionary<string, decimal> AveragePriceBySeries();
    }
}
