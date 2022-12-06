using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Request
{
    public abstract class UpdateRequest
    {
        public Guid Id { get; set; }
    }
}