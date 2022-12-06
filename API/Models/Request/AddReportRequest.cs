using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Request
{
    public class AddReportRequest
    {
        public string Reason { get; set; } = null!;
        public Guid? PostId { get; set; }
        public Guid? CommentId { get; set; }
    }
}