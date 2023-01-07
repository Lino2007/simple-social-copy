using SOC.DataContracts.Models;
using SOC.DataContracts.Request;
using SOC.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SOC.DataContracts.Response;

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
        public async Task<ActionResult<CategoryResponse>> GetCategoryById(Guid id)
        {
            var category = await categoryService.GetById(id);
            return (CategoryResponse)category;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryResponse>>> GetCategories()
        {
            var categories = (await categoryService.GetAll()).Select(t => (CategoryResponse)t);
            return new ActionResult<IEnumerable<CategoryResponse>>(categories);
        }

        [HttpPost]
        public async Task<ActionResult<CategoryResponse>> AddCategory([FromBody] AddCategoryRequest category)
        {
            return (CategoryResponse)(await categoryService.Add((Category)category));
        }

        [HttpPatch]
        public async Task<ActionResult<CategoryResponse>> UpdateCategory([FromBody] UpdateCategoryRequest category)
        {
            var updatedCategory = await categoryService.Update(category);
            return (CategoryResponse)updatedCategory;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(Guid id)
        {
            await categoryService.Delete(id);
            return NoContent();
        }
    }
}