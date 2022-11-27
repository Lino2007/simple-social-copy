using System.Threading.Tasks;
using API.Models;
using API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace API.Repository.Implementations
{
    public abstract class CrudRepository<T> : ReadRepository<T>, ICrudRepository<T> where T : CrudEntity
    {
        protected CrudRepository(SimpleSocialContext db) : base(db)
        {
        }

        public async virtual Task<T> Add(T entity)
        {
            await db.Set<T>().AddAsync(entity);
            await db.SaveChangesAsync();
            return entity;
        }

        public async virtual Task<T> Delete(T entity)
        {
            db.Set<T>().Remove(entity);
            await db.SaveChangesAsync();
            return entity;
        }

        public async virtual Task Update(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }
    }
}