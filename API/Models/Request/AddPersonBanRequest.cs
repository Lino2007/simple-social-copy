using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Request
{
    public class AddPersonBanRequest
    {
        public bool Active { get; set; }
        public DateTime? ActiveUntil { get; set; }
        public string Reason { get; set; } = null!;
        public Guid PersonId { get; set; }
    }
}