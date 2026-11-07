using BLogic.Interfaces;
using DataAccessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLogic.Realization
{
    /// <summary>
    /// Реализация CRUD-обязанности. Делегирует вызовы репазиторию
    /// </summary>
    public class OperationsCRUD : IOperationsCRUD
    {
        private readonly RepositoryProvider provider;

        /// <summary>
        /// Внедрение системы с актуальным репазиторием через конструктор
        /// </summary>
        /// <param name="provider"> Система с актульным репозиторием </param>
        /// <exception cref="ArgumentNullException"> Если provider равен null. </exception>
        public OperationsCRUD(RepositoryProvider provider)
        {
            this.provider = provider ?? throw new ArgumentNullException(nameof(provider)); ;
        }

        /// <summary>
        /// Добавление робота
        /// </summary>
        /// <param name="robot"> сущность робота </param>
        public void Add(Robot robot) => provider.Repository.Create(robot);

        /// <summary>
        /// Возвращение по ID
        /// </summary>
        /// <param name="id"> ID робота </param>
        /// <returns> Возвращение робота </returns>
        public Robot? GetById(int id) => provider.Repository.ReadById(id);

        /// <summary>
        /// Возвращение всех роботов
        /// </summary>
        /// <returns> Все роботы</returns>
        public List<Robot> GetAll() => provider.Repository.ReadAll().ToList();

        /// <summary>
        /// Редактируем робота
        /// </summary>
        /// <param name="robot"> Новый робот </param>
        public void Update(Robot robot) => provider.Repository.Update(robot);

        /// <summary>
        /// Удаление робота
        /// </summary>
        /// <param name="robot"> Удаляемый робот </param>
        public void Delete(Robot robot) => provider.Repository.Delete(robot);
    }
}
