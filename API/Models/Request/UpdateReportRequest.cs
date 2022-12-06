using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Request
{
    public class UpdateReportRequest : UpdateRequest
    {
        public string Reason { get; set; } = null!;
        public bool Resolved { get; set; }
    }
}