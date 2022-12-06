using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Request
{
    public class UpdatePersonRequest : UpdateRequest
    {
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string? Bio { get; set; }
        public string Country { get; set; } = null!;
        public DateTime? DateOfBirth { get; set; }
    }
}