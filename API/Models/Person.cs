using System;
using System.Collections.Generic;

namespace API
{
    public partial class Person
    {
        public Person()
        {
        }

        public Guid Id { get; set; }
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
    }
}
