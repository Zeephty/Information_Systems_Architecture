using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DataAccessLayer
{
    /// <summary>
    /// Репозиторий — инкапсулирует доступ к источнику данных для доменного объекта T.
    /// Конкретные реализации (JSON, Dapper, EF) живут в проекте DataAccessLayer.
    /// </summary>
    /// <typeparam name="T"> Тип доменного объекта. </typeparam>
    public interface IRepository<T> where T : IDomainObject, new()
    {
        /// <summary>
        /// Создать новую запись. Поле Id заполняется хранилищем.
        /// </summary>
        /// <param name="obj"> Доменный объект для добавления. </param>
        void Create(T obj);

        /// <summary>
        /// Прочитать все записи.
        /// </summary>
        /// <returns> Последовательность всех записей. </returns>
        IEnumerable<T> ReadAll();

        /// <summary>
        /// Прочитать запись по Id или вернуть null, если нет.
        /// </summary>
        /// <param name="id"> Идентификатор записи. </param>
        /// <returns> Найденная запись или null. </returns>
        T? ReadById(int id);

        /// <summary>
        /// Обновить существующую запись.
        /// </summary>
        /// <param name="obj"> Доменный объект с уже изменёнными полями. </param>
        void Update(T obj);

        /// <summary>
        /// Удалить запись.
        /// </summary>
        /// <param name="obj"> Доменный объект для удаления. </param>
        void Delete(T obj);
    }
}
