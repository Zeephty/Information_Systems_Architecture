using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Persistence
{
    /// <summary>
    /// Строка таблицы Types — справочник типов роботов.
    /// Persistence-модель, изолирована внутри DAL.
    /// </summary>
    internal class TypeRow
    {
        /// <summary> Уникальный идентификатор типа. </summary>
        public int Id { get; set; }
        /// <summary> Название типа (уникальное). </summary>
        public string Name { get; set; } = "";
    }
}
