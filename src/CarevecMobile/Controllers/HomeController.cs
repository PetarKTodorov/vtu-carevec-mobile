using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CarevecMobile.Constants;
using CarevecMobile.Data;
using CarevecMobile.Data.DataModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CarevecMobile.Controllers
{
    public class HomeController : BaseDatabaseController
    {
        public HomeController(ApplicationDbContext context) 
            : base(context)
        {
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
