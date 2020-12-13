﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuickBy.Repositorio.Context;

namespace QuickBy.Repositorio.Migrations
{
    [DbContext(typeof(QuickByContext))]
    partial class QuickByContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("QuickBy.Dominio.Entities.ItemOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId")
                        .HasColumnName("ORDER_ID");

                    b.Property<int>("ProductId")
                        .HasColumnName("PRODUCT_ID");

                    b.Property<int>("Quantity")
                        .HasColumnName("QUANTITY");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("ITEM_ORDER");
                });

            modelBuilder.Entity("QuickBy.Dominio.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnName("CEP")
                        .HasColumnType("VARCHAR(10)")
                        .HasMaxLength(10);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnName("CITY")
                        .HasColumnType("VARCHAR(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("DateOrder")
                        .HasColumnName("DATE_ORDER")
                        .HasColumnType("datetime");

                    b.Property<string>("Estate")
                        .IsRequired()
                        .HasColumnName("ESTATE")
                        .HasColumnType("VARCHAR(30)")
                        .HasMaxLength(30);

                    b.Property<int>("FormPaymentId")
                        .HasColumnName("FORM_PAYMENT_ID");

                    b.Property<string>("FullAddress")
                        .IsRequired()
                        .HasColumnName("FULL_ADDRESS")
                        .HasColumnType("VARCHAR(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnName("NUMBER")
                        .HasColumnType("VARCHAR(10)")
                        .HasMaxLength(10);

                    b.Property<DateTime>("PreviousDeliveryDate")
                        .HasColumnName("PREVIOUS_DELIVERY_DATE")
                        .HasColumnType("datetime");

                    b.Property<int>("UserId")
                        .HasColumnName("USER_ID");

                    b.HasKey("Id");

                    b.HasIndex("FormPaymentId");

                    b.HasIndex("UserId");

                    b.ToTable("ORDER");
                });

            modelBuilder.Entity("QuickBy.Dominio.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("DESCRIPTION")
                        .HasColumnType("VARCHAR(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("NAME")
                        .HasColumnType("VARCHAR(30)")
                        .HasMaxLength(30);

                    b.Property<decimal>("Price")
                        .HasColumnName("PRICE");

                    b.HasKey("Id");

                    b.ToTable("PRODUCT");
                });

            modelBuilder.Entity("QuickBy.Dominio.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("EMAIL")
                        .HasColumnType("VARCHAR(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("NAME")
                        .HasColumnType("VARCHAR(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("PASSWORD")
                        .HasColumnType("VARCHAR(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnName("SURNAME")
                        .HasColumnType("VARCHAR(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("USER");
                });

            modelBuilder.Entity("QuickBy.Dominio.ObjectValue.FormPayment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("DESCRIPTION")
                        .HasColumnType("VARCHAR(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("NAME")
                        .HasColumnType("VARCHAR(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("FORM_PAYMENT");
                });

            modelBuilder.Entity("QuickBy.Dominio.Entities.ItemOrder", b =>
                {
                    b.HasOne("QuickBy.Dominio.Entities.Order")
                        .WithMany("ItemOrders")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK_ORDER_ITEM_ORDER_ORDER_ID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("QuickBy.Dominio.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_ITEM_ORDER_PRODUCT_PRODUCT_ID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("QuickBy.Dominio.Entities.Order", b =>
                {
                    b.HasOne("QuickBy.Dominio.ObjectValue.FormPayment", "FormPayment")
                        .WithMany()
                        .HasForeignKey("FormPaymentId")
                        .HasConstraintName("FK_ORDER_FORM_PAYMENT_FORM_PAYMENT_ID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("QuickBy.Dominio.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_ORDER_USER_USER_ID")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}