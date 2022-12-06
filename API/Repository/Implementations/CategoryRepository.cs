using System.Threading.Tasks;
using API.Models;
using API.Models.Request;
using API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Repository.Implementations
{
    public class CategoryRepository : CrudRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(SimpleSocialContext db) : base(db)
        {
        }

        public async Task<Category?> UpdateCategory(UpdateCategoryRequest category)
        {
            var c = await db.Categories.SingleOrDefaultAsync(cat => cat.Id.Equals(category.Id));
            if (c == null)
            {
                return null;
            }
            db.Entry(c).CurrentValues.SetValues(category);
            return await Update(c);
        }
    }
}