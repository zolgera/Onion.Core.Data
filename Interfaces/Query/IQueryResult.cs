using System.Collections.Generic;
using Core.Data.Interfaces.Entitys;
using Core.Data.Query;

namespace core.Interfaces.Query
{
    public interface IQueryResult<T> where T : IBaseEntity
    {
        PageInfo PageInfo { get; }
        IEnumerable<T> Payload { get; }
    }
}