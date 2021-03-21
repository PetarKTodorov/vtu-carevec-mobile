using System;
using System.Threading.Tasks;
using CarevecMobile.Data;
using CarevecMobile.Data.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace CarevecMobile.Areas.Admin.Controllers
{
    public class PhoneController : BaseAdminController
    {
        public PhoneController(ApplicationDbContext context) 
            : base(context)
        {
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Phone phoneModel)
        {
            if (this.ModelState.IsValid == false)
            {
                return this.View(phoneModel);
            }

            await this.DbContext.Phones.AddAsync(phoneModel);
            await this.DbContext.SaveChangesAsync();

            return RedirectToAction("All", "Phone", new { area = "" });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var phone = await this.DbContext.Phones.FindAsync(id);

            if (phone == null)
            {
                return RedirectToAction("All", "Phone", new { area = "" });
            }

            return this.View(phone);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Phone phoneModel)
        {
            if (this.ModelState.IsValid == false)
            {
                return this.View(phoneModel);
            }

            var phone = await this.DbContext.Phones.FindAsync(id);

            if (phone == null)
            {
                return RedirectToAction("All", "Phone", new { area = "" });
            }

            phone.Brand = phoneModel.Brand;
            phone.Description = phoneModel.Description;
            phone.ImageUrl = phoneModel.ImageUrl;
            phone.Year = phoneModel.Year;
            phone.Price = phoneModel.Price;
            phone.Model = phoneModel.Model;

            this.DbContext.Phones.Update(phone);
            await this.DbContext.SaveChangesAsync();

            return RedirectToAction("All", "Phone", new { area = "" });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var phone = await this.DbContext.Phones.FindAsync(id);

            if (phone == null)
            {
                return RedirectToAction("All", "Phone", new { area = "" });
            }

            return this.View(phone);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id, Phone phoneModel)
        {
            var phone = await this.DbContext.Phones.FindAsync(id);

            if (phone == null)
            {
                return RedirectToAction("All", "Phone", new { area = "" });
            }

            this.DbContext.Phones.Remove(phone);
            await this.DbContext.SaveChangesAsync();

            return RedirectToAction("All", "Phone", new { area = "" });
        }
    }
}
