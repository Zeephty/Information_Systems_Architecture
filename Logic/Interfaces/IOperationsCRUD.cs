using DataAccessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLogic.Interfaces
{
    /// <summary>
    /// Обязанность: базовые CRUD-операции над сущностью
    /// </summary>
    public interface IOperationsCRUD
    {
        /// <summary>
        /// Добавить сущность в хранилище
        /// </summary>
        /// <param name="robot"> Сущность </param>
        void Add(Robot robot);

        /// <summary>
        /// Получаем по ID сущность
        /// </summary>
        /// <param name="id"> ID сущности </param>
        /// <returns> Возвращение сущности </returns>
        Robot? GetById(int id);

        /// <summary>
        /// Получить все сущности
        /// </summary>
        /// <returns> Все сущности </returns>
        List<Robot> GetAll();

        /// <summary>
        /// Обновить сущность
        /// </summary>
        /// <param name="robot"> Новая сущность </param>
        void Update(Robot robot);

        /// <summary>
        /// Удалить сущность
        /// </summary>
        /// <param name="robot"> Удаляемая сущность </param>
        void Delete(Robot robot);
    }
}
