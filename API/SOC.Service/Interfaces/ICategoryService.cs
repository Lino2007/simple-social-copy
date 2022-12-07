using SOC.DataContracts.Models;
using SOC.DataContracts.Request;

namespace SOC.Service.Interfaces
{
    public interface ICategoryService : ICrudService<Category>
    {
        public Task<Category?> Update(UpdateCategoryRequest entity);
    }
}