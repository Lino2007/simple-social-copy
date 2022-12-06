using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Request
{
    public class UpdatePostRequest : UpdateRequest
    {
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public bool? Locked { get; set; }
        public Guid CategoryId { get; set; }
    }
}