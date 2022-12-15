using System.ComponentModel.DataAnnotations;

namespace SOC.DataContracts.Request
{
    public class UpdatePostRequest : UpdateDto
    {
        [StringLength(50, MinimumLength = 5)]
        public string Title { get; set; } = null!;
        [StringLength(2048, MinimumLength = 2)]
        public string Content { get; set; } = null!;
        public bool? Locked { get; set; }
        public Guid CategoryId { get; set; }
    }
}