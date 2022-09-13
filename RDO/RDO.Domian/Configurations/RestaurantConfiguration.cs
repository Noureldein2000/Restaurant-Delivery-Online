using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RDO.Domian.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RDO.Domian.Configurations
{
    public class RestaurantConfiguration : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            builder.HasKey(s => s.ID);
            builder.HasOne(s=>s.City).WithMany(s=>s.Restaurants).HasForeignKey(s=>s.CityId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}