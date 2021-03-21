using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarevecMobile.Data.DataModels
{
    public class PhoneUserMapping
    {
        public string UserId { get; set; }
        public User User { get; set; }

        public int PhoneId { get; set; }
        public Phone Phone { get; set; }
    }
}
