using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CarevecMobile.Data.DataModels
{
    public class User : IdentityUser
    {
        public User()
        {
            this.PhonesMapping = new HashSet<PhoneUserMapping>();
            this.ServicePackages = new HashSet<ServicePackage>();
        }

        public ICollection<PhoneUserMapping> PhonesMapping { get; set; }

        public ICollection<ServicePackage> ServicePackages { get; set; }
    }
}
