using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RDO.Domian.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RDO.Domian.Configurations
{
    public class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasKey(s => s.ID);

            builder.HasOne(s => s.Restaurants).WithOne(s => s.Menu).HasForeignKey<Menu>(ad => ad.RestaurantId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}

