using System.Linq.Expressions;
using SOC.DataContracts.Models;
using SOC.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using SOC.Common.Exceptions;

namespace SOC.Repository.Implementations
{
    public abstract class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        protected SimpleSocialContext db;

        public ReadRepository(SimpleSocialContext db)
        {
            this.db = db;
        }

        public async virtual Task<IEnumerable<T>> FindBy(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = db.Set<T>();
            if (predicate is not null)
            {
                query = query.Where(predicate);
            }
            return await query.ToListAsync();
        }

        public async virtual Task<IEnumerable<T>> GetAll()
        {
            return await db.Set<T>().AsNoTracking().ToListAsync();
        }

        public async virtual Task<T> GetById(Guid id)
        {
            var result = (await this.FindBy(p => p.Id.Equals(id))).FirstOrDefault();
            if (result is null)
            {
                throw new ObjectNotFoundException(typeof(T), id);
            }
            return result;
        }
    }
}