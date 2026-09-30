using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Persistence
{
    /// <summary>
    /// Строка таблицы Series — справочник серий роботов.
    /// Persistence-модель, изолирована внутри DAL.
    /// </summary>
    internal class SeriesRow
    {
        /// <summary> Уникальный идентификатор серии. </summary>
        public int Id { get; set; }
        /// <summary> Название серии (уникальное). </summary>
        public string Name { get; set; } = "";
    }
}
