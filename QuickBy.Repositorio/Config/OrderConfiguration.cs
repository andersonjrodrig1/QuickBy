using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBy.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBy.Repositorio.Config
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("ORDER");

            builder.HasKey(o => o.Id);
            builder.Property(o => o.Id).HasColumnName("ID").UseMySqlIdentityColumn().IsRequired();
            builder.Property(o => o.DateOrder).HasColumnName("DATE_ORDER").HasColumnType("datetime").IsRequired();
            builder.Property(o => o.UserId).HasColumnName("USER_ID").IsRequired();
            builder.Property(o => o.PreviousDeliveryDate).HasColumnName("PREVIOUS_DELIVERY_DATE").HasColumnType("datetime").IsRequired();
            builder.Property(o => o.CEP).HasColumnName("CEP").HasColumnType("VARCHAR(10)").HasMaxLength(10).IsRequired();
            builder.Property(o => o.Estate).HasColumnName("ESTATE").HasColumnType("VARCHAR(30)").HasMaxLength(30).IsRequired();
            builder.Property(o => o.City).HasColumnName("CITY").HasColumnType("VARCHAR(50)").HasMaxLength(50).IsRequired();
            builder.Property(o => o.FullAddress).HasColumnName("FULL_ADDRESS").HasColumnType("VARCHAR(100)").HasMaxLength(100).IsRequired();
            builder.Property(o => o.Number).HasColumnName("NUMBER").HasColumnType("VARCHAR(10)").HasMaxLength(10).IsRequired();
            builder.Property(o => o.FormPaymentId).HasColumnName("FORM_PAYMENT_ID").IsRequired();

            builder.HasOne(o => o.User).WithMany(o => o.Orders).HasForeignKey(o => o.UserId).HasConstraintName("FK_ORDER_USER_USER_ID").OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(o => o.FormPayment).WithMany().HasForeignKey(o => o.FormPaymentId).HasConstraintName("FK_ORDER_FORM_PAYMENT_FORM_PAYMENT_ID").OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(o => o.ItemOrders).WithOne().HasForeignKey(o => o.OrderId).HasConstraintName("FK_ORDER_ITEM_ORDER_ORDER_ID").OnDelete(DeleteBehavior.Restrict);
        }
    }
}
