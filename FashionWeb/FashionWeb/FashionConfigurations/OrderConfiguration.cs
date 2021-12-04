using FashionWeb.Enums;
using FashionWeb.FashionEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FashionWeb.FashionConfigurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");

            builder.HasKey(x => x.OrderId);

            builder.Property(x => x.Name).IsRequired();

            builder.Property(x => x.Phone).IsRequired().HasDefaultValue<int>(0);

            builder.Property(x => x.Address).IsRequired();

            builder.Property(x => x.City).IsRequired();

            builder.Property(x => x.Ship).HasDefaultValue(OrderShip.InProgress);
        }
    }
}
