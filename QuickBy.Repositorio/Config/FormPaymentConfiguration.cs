using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBy.Dominio.ObjectValue;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBy.Repositorio.Config
{
    public class FormPaymentConfiguration : IEntityTypeConfiguration<FormPayment>
    {
        public void Configure(EntityTypeBuilder<FormPayment> builder)
        {
            builder.ToTable("FORM_PAYMENT");

            builder.HasKey(f => f.Id);
            builder.Property(f => f.Id).HasColumnName("ID").UseMySqlIdentityColumn().IsRequired();
            builder.Property(f => f.Name).HasColumnName("NAME").HasColumnType("VARCHAR(30)").HasMaxLength(30).IsRequired();
            builder.Property(f => f.Description).HasColumnName("DESCRIPTION").HasColumnType("VARCHAR(50").HasMaxLength(50).IsRequired();
        }
    }
}
