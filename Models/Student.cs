using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Management_System.Models
{
    public class Student : BaseEntity
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public int Age {get; set;}
        public int Roll {get; set;}
        public Status Status {get; set;}
    }
    public enum Status
    {
        Active,
        Inactive,
        Prospective,
        Intern
    }
}