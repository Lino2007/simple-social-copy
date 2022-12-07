using SOC.DataContracts.Models;
using SOC.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace SOC.Repository.Implementations
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

        public async virtual Task Delete(Guid id)
        {
            var entity = await db.Set<T>().SingleOrDefaultAsync(t => t.Id.Equals(id));
            if (entity != null)
            {
                db.Set<T>().Remove(entity);
                await db.SaveChangesAsync();
            }
        }

        public async virtual Task<T> Update(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return entity;
        }
    }
}