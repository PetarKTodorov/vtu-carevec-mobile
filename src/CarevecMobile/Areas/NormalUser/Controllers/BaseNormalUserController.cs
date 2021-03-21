using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarevecMobile.Constants;
using CarevecMobile.Controllers;
using CarevecMobile.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarevecMobile.Areas.NormalUser.Controllers
{
    [Area(GlobalConstants.UserArea)]
    [Authorize(Roles = GlobalConstants.UserRole)]
    public abstract class BaseNormalUserController : BaseDatabaseController
    {
        protected BaseNormalUserController(ApplicationDbContext context) 
            : base(context)
        {
        }
    }
}
