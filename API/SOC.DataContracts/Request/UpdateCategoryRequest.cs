using System.ComponentModel.DataAnnotations;
namespace SOC.DataContracts.Request
{
    public class UpdateCategoryRequest : UpdateDto
    {
        [StringLength(30, MinimumLength = 5)]
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}