using SOC.DataContracts.Models;

namespace SOC.Service.Interfaces
{
    public interface ICrudService<T> : IReadService<T> where T : CrudEntity
    {
        Task<T> Add(T entity);
        Task Delete(Guid id);
        Task<T> Update(T entity);
    }
}