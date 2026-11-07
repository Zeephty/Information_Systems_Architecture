using DataAccessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLogic
{
    /// <summary>
    /// Держатель актуального репозитория.
    /// </summary>
    public class RepositoryProvider
    {
        /// <summary>
        /// Текущий репозиторий
        /// </summary>
        public IRepository<Robot> Repository { get; private set; }

        /// <summary>
        /// Создает держатель с начальным репазиторием
        /// </summary>
        /// <param name="repository"> Репазиторий </param>
        /// <exception cref="ArgumentNullException"> Если repository равен null. </exception>
        public RepositoryProvider(IRepository<Robot> repository)
        {
            Repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        /// <summary>
        /// Заменяет текущий репозиторий
        /// </summary>
        /// <param name="repository"> Репазиторий новый </param>
        /// <exception cref="ArgumentNullException"> Если repository равен null. </exception>
        public void SetRepository(IRepository<Robot> repository)
        {
            Repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
    }
}
