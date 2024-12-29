using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Management_System.Models
{
    public class Contact : BaseEntity
    {
        public int Id {get; set;}
        public string PhoneNumber {get; set;}
        public ContactStatus Status {get; set;}
    }
    public enum ContactStatus
    {
        Active,
        Inactive,
        Pending, 
        Archieved
    }
}