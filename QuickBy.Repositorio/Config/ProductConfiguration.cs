using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBy.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBy.Repositorio.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("PRODUCT");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("ID").UseMySqlIdentityColumn().IsRequired();
            builder.Property(p => p.Name).HasColumnName("NAME").HasColumnType("VARCHAR(30)").HasMaxLength(30).IsRequired();
            builder.Property(p => p.Description).HasColumnName("DESCRIPTION").HasColumnType("VARCHAR(100)").HasMaxLength(100).IsRequired();
            builder.Property(p => p.Price).HasColumnName("PRICE").IsRequired();
        }
    }
}
