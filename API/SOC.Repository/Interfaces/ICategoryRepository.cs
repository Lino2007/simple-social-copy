using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SOC.DataContracts.Models;
using SOC.DataContracts.Request;

namespace SOC.Repository.Interfaces
{
    public interface ICategoryRepository : ICrudRepository<Category>
    {
        Task<Category?> UpdateCategory(UpdateCategoryRequest category);
    }
}