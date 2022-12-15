﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace OrderProject.Migrations
{
    [DbContext(typeof(OrderDbContext))]
    [Migration("20221214150104_AddedOrder")]
    partial class AddedOrder
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("order")
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Order.Contracts.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<Guid>("BuyerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("OrderDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("Orders", "order");
                });

            modelBuilder.Entity("Order.Contracts.Entities.Order", b =>
                {
                    b.OwnsOne("Order.Contracts.Entities.Address", "ShipToAddress", b1 =>
                        {
                            b1.Property<int>("OrderId")
                                .HasColumnType("int");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)");

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasMaxLength(90)
                                .HasColumnType("nvarchar(90)");

                            b1.Property<string>("State")
                                .IsRequired()
                                .HasMaxLength(60)
                                .HasColumnType("nvarchar(60)");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasMaxLength(180)
                                .HasColumnType("nvarchar(180)");

                            b1.Property<string>("ZipCode")
                                .IsRequired()
                                .HasMaxLength(18)
                                .HasColumnType("nvarchar(18)");

                            b1.HasKey("OrderId");

                            b1.ToTable("Orders", "order");

                            b1.WithOwner()
                                .HasForeignKey("OrderId");
                        });

                    b.OwnsMany("Order.Contracts.Entities.OrderItem", "OrderItems", b1 =>
                        {
                            b1.Property<int>("OrderId")
                                .HasColumnType("int");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"), 1L, 1);

                            b1.Property<decimal>("UnitPrice")
                                .HasPrecision(18, 2)
                                .HasColumnType("decimal(18,2)");

                            b1.Property<byte>("Units")
                                .HasColumnType("tinyint");

                            b1.HasKey("OrderId", "Id");

                            b1.ToTable("OrderItem", "order");

                            b1.WithOwner()
                                .HasForeignKey("OrderId");

                            b1.OwnsOne("Order.Contracts.Entities.ProductOrdered", "ProductOrdered", b2 =>
                                {
                                    b2.Property<int>("OrderItemOrderId")
                                        .HasColumnType("int");

                                    b2.Property<int>("OrderItemId")
                                        .HasColumnType("int");

                                    b2.Property<string>("PictureUri")
                                        .IsRequired()
                                        .HasColumnType("nvarchar(max)");

                                    b2.Property<int>("ProductId")
                                        .HasColumnType("int");

                                    b2.Property<string>("ProductName")
                                        .IsRequired()
                                        .HasMaxLength(50)
                                        .HasColumnType("nvarchar(50)");

                                    b2.HasKey("OrderItemOrderId", "OrderItemId");

                                    b2.ToTable("OrderItem", "order");

                                    b2.WithOwner()
                                        .HasForeignKey("OrderItemOrderId", "OrderItemId");
                                });

                            b1.Navigation("ProductOrdered")
                                .IsRequired();
                        });

                    b.Navigation("OrderItems");

                    b.Navigation("ShipToAddress")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
