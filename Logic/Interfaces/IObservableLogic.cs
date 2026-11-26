using System;
using System.Collections.Generic;
using System.Text;

namespace BLogic.Interfaces
{
    /// <summary>
    /// Расширение для логики, позволяющее подписываться на изменения.
    /// </summary>
    public interface IObservableLogic : ILogic
    {
        /// <summary>
        /// Событие изменинения данных
        /// </summary>
        event Action DataChanged;
    }
}
