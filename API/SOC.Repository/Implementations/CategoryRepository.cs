using SOC.DataContracts.Models;
using SOC.DataContracts.Request;
using Microsoft.EntityFrameworkCore;
using SOC.Repository.Interfaces;

namespace SOC.Repository.Implementations
{
    public class CategoryRepository : CrudRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(SimpleSocialContext db) : base(db)
        {
        }
    }
}