using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarevecMobile.Constants;
using CarevecMobile.Data;
using CarevecMobile.Data.DataModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CarevecMobile.Areas.NormalUser.Controllers
{
    public class UserController : BaseNormalUserController
    {
        private readonly UserManager<User> userManager;

        public UserController(ApplicationDbContext context, UserManager<User> userManager) 
            : base(context)
        {
            this.userManager = userManager;
        }

        public async Task<IActionResult> Buy(int phoneId)
        {
            var phone = await this.DbContext.Phones.FindAsync(phoneId);

            if (phone == null)
            {
                return RedirectToAction("All", "Phone", new { area = "" });
            }

            var newUserPhone = new PhoneUserMapping();
            newUserPhone.PhoneId = phoneId;
            newUserPhone.UserId = this.userManager.GetUserId(this.User);

            if (newUserPhone.UserId == null)
            {
                return RedirectToAction("All", "Phone", new { area = "" });
            }

            bool isAllreadtExist = this.DbContext.PhonesUsersMapping
                .Any(pum => pum.PhoneId == newUserPhone.PhoneId && pum.UserId == newUserPhone.UserId);

            if (isAllreadtExist)
            {
                return RedirectToAction("All", "Phone", new { area = "" });
            }

            await this.DbContext.PhonesUsersMapping.AddAsync(newUserPhone);
            await this.DbContext.SaveChangesAsync();

            return RedirectToAction("MyAll", "User", new { area = GlobalConstants.UserArea });
        }

        public async Task<IActionResult> MyAll()
        {
            var currentUser = await this.userManager.GetUserAsync(this.User);

            var userPhones = this.DbContext.Phones
                .Where(phone => phone.UserMapping.Select(u => u.UserId).Contains(currentUser.Id))
                .ToArray();

            return this.View(userPhones);
        }
    }
}
