using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SOC.DataContracts.Models;

namespace SOC.Repository.Interfaces
{
    public interface IReadRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> FindBy(Expression<Func<T, bool>> predicate);
        Task<T?> GetById(Guid id);
    }
}