using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public class RobotDTO
    {
        /// <summary> Уникальный индентификатор робота (например, RB-001). </summary>
        public int Id { get; set; }

        /// <summary> Порядковый номер внутри серии. </summary>
        public int Number { get; set; }

        /// <summary> Серия робота (например, KX, YoRHa). </summary>
        public string Series { get; set; } = "";

        /// <summary> Тип робота (Андроид, Дрон, Мех и т.д.). </summary>
        public string Type { get; set; } = "";

        /// <summary> Название модели (например, KX-11 «Тень»). </summary>
        public string Name { get; set; } = "";

        /// <summary> Основная цель или назначение робота. </summary>
        public string Goal { get; set; } = "";

        /// <summary> Технические детали и особенности конструкции. </summary>
        public string Details { get; set; } = "";

        /// <summary> Описание внешнего вида. </summary>
        public string Appearance { get; set; } = "";

        /// <summary>Список кодов критериев, по которым начислены баллы. </summary>
        public List<int> CriteriaCodes { get; set; } = new List<int>();

        /// <summary> Примерная стоимость создания в рублях. </summary>
        public decimal PriceRub { get; set; }

        public RobotDTO() { }
    }
}
