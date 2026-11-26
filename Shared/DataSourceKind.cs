using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    /// <summary>
    /// Тип источника данных, между которыми можно переключаться во время работы.
    /// </summary>
    public enum DataSourceKind
    {
        Json,
        Dapper,
        EntityFramework
    }
}
