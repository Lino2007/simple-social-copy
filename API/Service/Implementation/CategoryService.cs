using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using API.Models.Request;
using API.Repository.Interfaces;
using API.Service.Interfaces;

namespace API.Service.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public async Task<Category> Add(Category entity)
        {
            return await categoryRepository.Add(entity);
        }

        public async Task Delete(Guid id)
        {
            await categoryRepository.Delete(id);
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return await categoryRepository.GetAll();
        }

        public async Task<Category?> GetById(Guid id)
        {
            return await categoryRepository.GetById(id);
        }

        public async Task<Category> Update(Category entity)
        {
            return await categoryRepository.Update(entity);
        }

        public async Task<Category?> Update(UpdateCategoryRequest entity)
        {
            return await categoryRepository.UpdateCategory(entity);
        }
    }
}