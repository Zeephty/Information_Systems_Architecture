using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// Статический класс, содержащий легенду критериев оценки роботов.
    /// </summary>
    public static class CriteriaLegend
    {
        /// <summary>
        /// Словарь, сопоставляющий код критерия (1–10) с его текстовым описанием.
        /// </summary>
        public static readonly Dictionary<int, string> Legend = new Dictionary<int, string>()
        {
            {1, "+1б за продвинутый ИИ"},
            {2, "+1б за отличную манёвренность"},
            {3, "+1б за высокую огневую мощь"},
            {4, "+1б за прочную защиту"},
            {5, "+1б за автономность"},
            {6, "+1б за адаптивность"},
            {7, "+1б за эффективность в роли"},
            {8, "+1б за надёжность"},
            {9, "+1б за универсальность"},
            {10, "+1б за инновационность"}
        };

        /// <summary>
        /// Преобразует набор кодов критериев в читаемую строку.
        /// </summary>
        /// <param name="codes"> Перечисление кодов критериев. </param>
        /// <returns> Строка с описаниями, разделёнными точкой с запятой. </returns>
        public static string Describe(IEnumerable<int> codes)
            => string.Join("; ", codes.Select(c => Legend.TryGetValue(c, out var text) ? text : $"+{c}б"));
    }
}
