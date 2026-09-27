using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// Сущность "Робот". Содержит все характеристики робота.
    /// </summary>
    public class Robot
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

        /// <summary>
        /// Возвращает строковое представление робота в формате:
        /// ID | Серия-Номер | Название | Тип | Оценка | Цена.
        /// </summary>
        /// <returns> Строка с краткой информацией о роботе. </returns>
        public override string ToString()
            => $"{Id} | {Series}-{Number} | {Name} | {Type} | {CriteriaCodes.Count}/10 | {PriceRub:N0} руб.";

        /// <summary>
        /// Создаёт независимую копию робота.
        /// </summary>
        /// <returns> Возращает копию робота </returns>
        public Robot Clone() => new Robot
        {
            Id = this.Id,
            Number = this.Number,
            Series = this.Series,
            Type = this.Type,
            Name = this.Name,
            Goal = this.Goal,
            Details = this.Details,
            Appearance = this.Appearance,
            CriteriaCodes = new List<int>(this.CriteriaCodes),
            PriceRub = this.PriceRub
        };

    }
}
