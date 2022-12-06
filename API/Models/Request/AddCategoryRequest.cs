using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Request
{
    public class AddCategoryRequest
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public Guid ForumCreator { get; set; }
    }
}