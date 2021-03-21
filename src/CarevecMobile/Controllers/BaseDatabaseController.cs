using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarevecMobile.Data;
using Microsoft.AspNetCore.Mvc;

namespace CarevecMobile.Controllers
{
    public abstract class BaseDatabaseController : Controller
    {
        protected BaseDatabaseController(ApplicationDbContext context)
        {
            this.DbContext = context;
        }

        protected ApplicationDbContext DbContext { get; set; }
    }
}
