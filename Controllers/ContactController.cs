using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Student_Management_System.Application;

namespace Student_Management_System.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _CONTEXT;
        public ContactController(AppDbContext _context)
        {
            _CONTEXT = _context;
        }
        public IActionResult List()
        {
            var contacts = _CONTEXT.Contacts.ToList();
            return View(contacts);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}