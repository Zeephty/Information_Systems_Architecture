using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Persistence
{
    /// <summary>
    /// Строка-таблицы RobotCriteria — связь робота с критериями.
    /// Составной PK: { RobotId, CriterionCode }.
    /// </summary>
    internal class RobotCriterionRow
    {
        /// <summary> FK на таблицу Robots. </summary>
        public int RobotId { get; set; }
        /// <summary> FK на таблицу Criteria. </summary>
        public int CriterionCode { get; set; }

        /// <summary> Навигация на робота. </summary>
        public RobotRow? Robot { get; set; }
        /// <summary> Навигация на критерий. </summary>
        public CriterionRow? Criterion { get; set; }
    }
}
