using System.ComponentModel.DataAnnotations;

namespace SOC.DataContracts.Request
{
    public class AddCommentRequest
    {
        [StringLength(255, MinimumLength = 1)]
        public string Content { get; set; } = null!;

        public Guid AuthorId { get; set; }

        public Guid PostId { get; set; }
    }
}