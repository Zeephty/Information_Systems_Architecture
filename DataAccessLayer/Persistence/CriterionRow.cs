using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Persistence
{
    /// <summary>
    /// Строка таблицы Criteria — справочник критериев оценки (коды 1..10).
    /// Persistence-модель, изолирована внутри DAL.
    /// </summary>
    internal class CriterionRow
    {
        /// <summary> Код критерия (PK, значения 1..10). </summary>
        public int Code { get; set; }
        /// <summary> Текстовое описание критерия. </summary>
        public string Description { get; set; } = "";
    }
}
