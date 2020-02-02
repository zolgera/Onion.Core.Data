using Core.Data.Interfaces.Entitys;

namespace Core.Data.Interfaces.Query
{
    public interface IDocumentResult<T> where T : IBaseEntity
    {
        T Payload { get; }
    }
}