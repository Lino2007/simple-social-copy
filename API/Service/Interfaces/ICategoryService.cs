using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using API.Models.Request;

namespace API.Service.Interfaces
{
    public interface ICategoryService : ICrudService<Category>
    {
        public Task<Category?> Update(UpdateCategoryRequest entity);
    }
}