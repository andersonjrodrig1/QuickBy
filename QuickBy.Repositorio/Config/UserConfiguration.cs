using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBy.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBy.Repositorio.Config
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("USER");

            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).HasColumnName("ID").UseMySqlIdentityColumn().IsRequired();
            builder.Property(u => u.Email).HasColumnName("EMAIL").HasColumnType("VARCHAR(30)").HasMaxLength(30).IsRequired();
            builder.Property(u => u.Password).HasColumnName("PASSWORD").HasColumnType("VARCHAR(40)").HasMaxLength(40).IsRequired();
            builder.Property(u => u.Name).HasColumnName("NAME").HasColumnType("VARCHAR(20)").HasMaxLength(20).IsRequired();
            builder.Property(u => u.Surname).HasColumnName("SURNAME").HasColumnType("VARCHAR(50)").HasMaxLength(50).IsRequired();
        }
    }
}
