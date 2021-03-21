using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarevecMobile.Data.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarevecMobile.Data.EntityTypeConfigurations
{
    public class PhoneUserMappingConfiguration : IEntityTypeConfiguration<PhoneUserMapping>
    {
        public void Configure(EntityTypeBuilder<PhoneUserMapping> builder)
        {
            builder.HasKey(pum => new { pum.PhoneId, pum.UserId });

            builder.HasOne(pum => pum.Phone)
                .WithMany(p => p.UserMapping)
                .HasForeignKey(pum => pum.PhoneId);

            builder.HasOne(pum => pum.User)
                .WithMany(u => u.PhonesMapping)
                .HasForeignKey(pum => pum.UserId);
        }
    }
}
