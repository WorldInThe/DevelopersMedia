using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp_Core_Testing.Data;
using Microsoft.AspNetCore.Mvc;

namespace Asp_Core_Testing.Controllers
{
    public class UserViewsController : Controller
    {
        private readonly ApplicationDbContext db;

        public UserViewsController(ApplicationDbContext context)
        {
            db = context;
        }

        public IActionResult Home()
        {
            var UItem = db.User.ToList().Find(m => m.Email.Contains(User.Identity.Name));
            return View(UItem);
        }

        //public IActionResult

    }
}