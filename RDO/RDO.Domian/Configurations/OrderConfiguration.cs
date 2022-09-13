using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RDO.Domian.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RDO.Domian.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(s => s.ID);

            builder.HasOne(s => s.Customer).WithOne(s => s.Order).HasForeignKey<Order>(ad => ad.CustomerId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(s => s.Restaurant).WithOne(s => s.Order).HasForeignKey<Order>(ad => ad.RestaurantId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
