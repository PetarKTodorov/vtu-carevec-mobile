using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarevecMobile.Data.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarevecMobile.Data.EntityTypeConfigurations
{
    public class PhoneConfiguration : IEntityTypeConfiguration<Phone>
    {
        public void Configure(EntityTypeBuilder<Phone> builder)
        {
            builder.Property(p => p.Price)
                .HasColumnType("DECIMAL(15, 2)");
        }
    }
}
