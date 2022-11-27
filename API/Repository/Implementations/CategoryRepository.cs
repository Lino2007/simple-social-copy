using API.Models;
using API.Repository.Interfaces;

namespace API.Repository.Implementations
{
    public class CategoryRepository : CrudRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(SimpleSocialContext db) : base(db)
        {
        }
    }
}