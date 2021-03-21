using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarevecMobile.Data;
using Microsoft.AspNetCore.Mvc;

namespace CarevecMobile.Controllers
{
    public class PhoneController : BaseDatabaseController
    {
        public PhoneController(ApplicationDbContext context) 
            : base(context)
        {
        }

        public IActionResult All()
        {
            var allPhones = this.DbContext.Phones.ToArray();

            return View(allPhones);
        }

        public async Task<IActionResult> Details(int id)
        {
            var phone = await this.DbContext.Phones.FindAsync(id);

            if (phone == null)
            {
                return RedirectToAction("All", "Phone", new { area = "" });
            }

            return this.View(phone);
        }
    }
}
