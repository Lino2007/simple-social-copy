using System.ComponentModel.DataAnnotations;

namespace SOC.DataContracts.Request
{
    public class UpdatePersonRequest : UpdateDto
    {
        [StringLength(30, MinimumLength = 2)]
        public string Firstname { get; set; } = null!;
        [StringLength(30, MinimumLength = 2)]
        public string Lastname { get; set; } = null!;
        public string? Bio { get; set; }
        public string Country { get; set; } = null!;
        public DateTime? DateOfBirth { get; set; }
    }
}