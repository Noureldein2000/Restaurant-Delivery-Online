using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RDO.Domian.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RDO.Domian.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(s => s.ID);
            builder.HasOne(s => s.Menu).WithMany(s => s.OrderDetails).HasForeignKey(ad => ad.MenuId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(s => s.Order).WithMany(s => s.OrderDetails).HasForeignKey(ad => ad.OrderId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
