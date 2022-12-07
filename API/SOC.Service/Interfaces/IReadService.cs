using SOC.DataContracts.Models;

namespace SOC.Service.Interfaces
{
    public interface IReadService<T> where T : BaseEntity
    {
        Task<T?> GetById(Guid id);
        Task<IEnumerable<T>> GetAll();
    }
}