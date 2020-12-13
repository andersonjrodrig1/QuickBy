using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBy.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBy.Repositorio.Config
{
    public class ItemOrderConfiguration : IEntityTypeConfiguration<ItemOrder>
    {
        public void Configure(EntityTypeBuilder<ItemOrder> builder)
        {
            builder.ToTable("ITEM_ORDER");

            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).HasColumnName("ID").UseMySqlIdentityColumn().IsRequired();
            builder.Property(i => i.ProductId).HasColumnName("PRODUCT_ID").IsRequired();
            builder.Property(i => i.Quantity).HasColumnName("QUANTITY").IsRequired();
            builder.Property(i => i.OrderId).HasColumnName("ORDER_ID").IsRequired();

            builder.HasOne(i => i.Product).WithMany().HasForeignKey(i => i.ProductId).HasConstraintName("FK_ITEM_ORDER_PRODUCT_PRODUCT_ID").OnDelete(DeleteBehavior.Restrict);
        }
    }
}
