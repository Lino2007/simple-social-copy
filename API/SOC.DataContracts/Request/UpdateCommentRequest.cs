using System.ComponentModel.DataAnnotations;
namespace SOC.DataContracts.Request
{
    public class UpdateCommentRequest : UpdateDto
    {
        [StringLength(255, MinimumLength = 1)]
        public string Content { get; set; } = null!;
        public bool Editable { get; set; }
    }
}