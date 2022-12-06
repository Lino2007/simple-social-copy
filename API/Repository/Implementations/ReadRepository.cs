using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using API.Models;
using API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Repository.Implementations
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

        public async virtual Task<T?> GetById(Guid id)
        {
            return (await this.FindBy(p => p.Id.Equals(id))).FirstOrDefault();
        }
    }
}