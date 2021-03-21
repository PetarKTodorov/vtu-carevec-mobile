
using CarevecMobile.Constants;
using CarevecMobile.Controllers;
using CarevecMobile.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarevecMobile.Areas.Admin.Controllers
{
    [Area(GlobalConstants.AdminArea)]
    [Authorize(Roles = GlobalConstants.AdminRole)]
    public abstract class BaseAdminController : BaseDatabaseController
    {
        protected BaseAdminController(ApplicationDbContext context) 
            : base(context)
        {
        }
    }
}
