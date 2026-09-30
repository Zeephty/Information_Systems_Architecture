using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Persistence
{
    /// <summary>
    /// Строка таблицы Robots — основная сущность робота.
    /// Series и Type вынесены в справочники через FK,
    /// критерии хранятся в таблице RobotCriteria.
    /// </summary>
    internal class RobotRow
    {
        /// <summary> Уникальный идентификатор робота (IDENTITY). </summary>
        public int Id { get; set; }
        /// <summary> Порядковый номер внутри серии. </summary>
        public int Number { get; set; }

        /// <summary> FK на справочник Series. </summary>
        public int SeriesId { get; set; }
        /// <summary> FK на справочник Types. </summary>
        public int TypeId { get; set; }

        /// <summary> Название модели. </summary>
        public string Name { get; set; } = "";
        /// <summary> Основная цель или назначение. </summary>
        public string Goal { get; set; } = "";
        /// <summary> Технические детали конструкции. </summary>
        public string Details { get; set; } = "";
        /// <summary> Описание внешнего вида. </summary>
        public string Appearance { get; set; } = "";
        /// <summary> Примерная стоимость создания в рублях. </summary>
        public decimal PriceRub { get; set; }

        /// <summary> Навигация на справочник серий. </summary>
        public SeriesRow? Series { get; set; }
        /// <summary> Навигация на справочник типов. </summary>
        public TypeRow? Type { get; set; }
        /// <summary> Навигация на связи робота с критериями. </summary>
        public List<RobotCriterionRow> Criteria { get; set; } = new();
    }
}
