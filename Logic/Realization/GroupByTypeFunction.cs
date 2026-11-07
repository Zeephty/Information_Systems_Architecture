using BLogic.Interfaces;
using DataAccessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLogic.Realization
{
    /// <summary>
    /// Бизнес-функция: группирует роботов по типу.
    /// </summary>
    public class CGroupByTypeFunction : IGroupByTypeFunction
    {
        private readonly RepositoryProvider provider;

        /// <summary>
        /// Создаёт компонент с внедрённой системой с актуальным репазиторием.
        /// </summary>
        /// <param name="provider"> Система с актуальным репозиторием для доступа к данным </param>
        /// <exception cref="ArgumentNullException"> Если provider равен null. </exception>
        public CGroupByTypeFunction(RepositoryProvider provider)
        {
            this.provider = provider ?? throw new ArgumentNullException(nameof(provider));
        }

        /// <summary>
        /// Бизнес-функция: группирует роботов по типу.
        /// </summary>
        /// <returns> Словарь, где ключ — тип, значение — список роботов. </returns>
        public Dictionary<string, List<Robot>> GroupByType()
            => provider.Repository.ReadAll().GroupBy(r => r.Type).ToDictionary(g => g.Key, g => g.ToList());
    }
}
