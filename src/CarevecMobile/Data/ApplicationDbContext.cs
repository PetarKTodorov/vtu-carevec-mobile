using System;
using System.Collections.Generic;
using System.Text;
using CarevecMobile.Data.DataModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarevecMobile.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Phone> Phones { get; set; }

        public DbSet<PhoneUserMapping> PhonesUsersMapping { get; set; }

        public DbSet<ServicePackage> ServicePackages { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }

    }
}
