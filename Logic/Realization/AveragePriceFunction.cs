using BLogic.Interfaces;
using DataAccessLayer;
using Model;
using Ninject.Activation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLogic.Realization
{
    /// <summary>
    /// Бизнес-функция: средняя цена по серии.
    /// </summary>
    public class CAveragePriceFunction : IAveragePriceFunction
    {
        private readonly RepositoryProvider provider;

        /// <summary>
        /// Создаёт компонент с внедрённой системой с актуальным репазиторием.
        /// </summary>
        /// <param name="provider"> Система с актуальным репозиторием для доступа к данным. </param>
        /// <exception cref="ArgumentNullException"> Если provider равен null. </exception>
        public CAveragePriceFunction(RepositoryProvider provider)
        {
            this.provider = provider ?? throw new ArgumentNullException(nameof(provider));
        }

        /// <summary>
        /// Возвращает словарь: ключ — тип, значение — список роботов этого типа.
        /// </summary>
        /// <returns> Словарь со средней ценой. </returns>
        public Dictionary<string, decimal> AveragePriceBySeries()
            => provider.Repository.ReadAll().GroupBy(r => r.Series).ToDictionary(g => g.Key, g => g.Average(r => r.PriceRub));
    }
}
