using SOC.DataContracts.Models;
using SOC.DataContracts.Request;
using SOC.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace SOC.REST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Category?>> GetCategoryById(Guid id)
        {
            return await categoryService.GetById(id);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            return new ActionResult<IEnumerable<Category>>(await categoryService.GetAll());
        }

        [HttpPost]
        public async Task<ActionResult<Category>> AddCategory([FromBody] AddCategoryRequest category)
        {
            return await categoryService.Add((Category)category);
        }

        [HttpPatch]
        public async Task<ActionResult<Category?>> UpdateCategory([FromBody] UpdateCategoryRequest category)
        {
            return await categoryService.Update(category);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(Guid id)
        {
            await categoryService.Delete(id);
            return NoContent();
        }
    }
}