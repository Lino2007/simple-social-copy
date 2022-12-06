using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Request
{
    public class UpdateCommentRequest : UpdateRequest
    {
        public string Content { get; set; } = null!;
        public bool Editable { get; set; }
    }
}