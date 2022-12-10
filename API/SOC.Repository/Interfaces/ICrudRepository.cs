using SOC.DataContracts.Models;
using SOC.DataContracts.Request;

namespace SOC.Repository.Interfaces
{
    public interface ICrudRepository<T> : IReadRepository<T> where T : CrudEntity
    {
        Task<T> Add(T entity);
        Task Delete(Guid id);
        Task<T> Update(T entity);
        Task<T?> Update(UpdateDto dtoEntity);
    }
}