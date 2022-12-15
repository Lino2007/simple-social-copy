using System.ComponentModel.DataAnnotations;

namespace SOC.DataContracts.Request
{
    public class AddPostRequest
    {
        [StringLength(50, MinimumLength = 5)]
        public string Title { get; set; } = null!;
        [StringLength(2048, MinimumLength = 2)]
        public string Content { get; set; } = null!;
        public Guid CategoryId { get; set; }
    }
}