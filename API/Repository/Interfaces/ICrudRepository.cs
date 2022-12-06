using System;
using System.Threading.Tasks;
using API.Models;

namespace API.Repository.Interfaces
{
    public interface ICrudRepository<T> : IReadRepository<T> where T : CrudEntity
    {
        Task<T> Add(T entity);
        Task Delete(Guid id);
        Task<T> Update(T entity);
    }
}