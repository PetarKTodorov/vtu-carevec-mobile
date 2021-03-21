using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarevecMobile.Data;
using Microsoft.AspNetCore.Mvc;

namespace CarevecMobile.Areas.Admin.Controllers
{
    public class HomeController : BaseAdminController
    {
        public HomeController(ApplicationDbContext context) 
            : base(context)
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
