using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Management_System.Models
{
    public class BaseEntity
    {
        public int Id {get; set;}
        public string Email {get; set;}
        public string Country {get; set;}
        public string Address {get; set;}
    }
}