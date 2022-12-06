using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Service.Interfaces
{
    public interface ICrudService<T> : IReadService<T> where T : CrudEntity
    {
        Task<T> Add(T entity);
        Task Delete(Guid id);
        Task<T> Update(T entity);
    }
}