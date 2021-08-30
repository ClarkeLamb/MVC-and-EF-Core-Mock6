using System;
using System.Collections.Generic;

#nullable disable

namespace Mock6.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int? Age { get; set; }
        public decimal? Salary { get; set; }
    }
}
