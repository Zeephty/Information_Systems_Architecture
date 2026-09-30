using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// Доменный объект — сущность, которую можно хранить в репозитории.
    /// Гарантирует наличие уникального идентификатора.
    /// </summary>
    public interface IDomainObject
    {
        /// <summary> Уникальный идентификатор сущности в хранилище. </summary>
        int Id { get; set; }
    }
}
