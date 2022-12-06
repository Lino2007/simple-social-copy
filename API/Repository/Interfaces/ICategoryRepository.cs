using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using API.Models.Request;

namespace API.Repository.Interfaces
{
    public interface ICategoryRepository : ICrudRepository<Category>
    {
        Task<Category?> UpdateCategory(UpdateCategoryRequest category);
    }
}