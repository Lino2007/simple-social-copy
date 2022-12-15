using System.ComponentModel.DataAnnotations;
namespace SOC.DataContracts.Request
{
    public class AddCategoryRequest
    {
        [StringLength(30, MinimumLength = 5)]
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public Guid ForumCreator { get; set; }
    }
}