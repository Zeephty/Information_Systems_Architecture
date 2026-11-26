using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    /// <summary>
    /// Интерфейс
    /// </summary>
    public interface IView
    {
        /// <summary>
        /// Событие добавления робота
        /// </summary>
        event Action<RobotDTO>? AddRobotRequested;

        /// <summary>
        /// Событие редактирования робота
        /// </summary>
        event Action<RobotDTO>? UpdateRobotRequested;

        /// <summary>
        /// Событие удаления робота
        /// </summary>
        event Action<int>? DeleteRobotRequested;

        /// <summary>
        /// Событие нахождения первого робота
        /// </summary>
        event Action<int>? FindRobotRequested;

        /// <summary>
        /// Событие обновления
        /// </summary>
        event Action? RefreshRequested;

        /// <summary>
        /// Событие изменения источника
        /// </summary>
        event Action<DataSourceKind>? ChangeSourceRequested;

        /// <summary>
        /// Событие на группировку
        /// </summary>
        event Action? GroupByTypeRequested;

        /// <summary>
        /// Событие на подсчет ср. знач.
        /// </summary>
        event Action? AveragePriceRequested;


        /// <summary>
        /// Показать роботов
        /// </summary>
        /// <param name="robots"> DTO робота </param>
        void ShowRobots(IEnumerable<RobotDTO> robots);

        /// <summary>
        /// Показать ошибку
        /// </summary>
        /// <param name="message"> Сообщение о ошибке </param>
        void ShowError(string message);

        /// <summary>
        /// Показать сообщение
        /// </summary>
        /// <param name="message"> Показ сообщения </param>
        void ShowMessage(string message);

        /// <summary>
        /// Подробнее посмореть сущность
        /// </summary>
        /// <param name="robot"> DTO робота </param>
        void ShowDetails(RobotDTO robot);

        /// <summary>
        /// Отрисовка группировки
        /// </summary>
        /// <param name="groups"> Словарь из сгруппированных элементов </param>
        void ShowGrouping(Dictionary<string, List<RobotDTO>> groups);

        /// <summary>
        /// Отрисовка ср. арифм
        /// </summary>
        /// <param name="stats"> Словарь ср. арифм </param>
        void ShowAveragePrice(Dictionary<string, decimal> stats);

        /// <summary>
        /// Отобразить обновленный источник
        /// </summary>
        /// <param name="sourceName"> Новый источник </param>
        void UpdateSourceLabel(string sourceName);
    }
}
