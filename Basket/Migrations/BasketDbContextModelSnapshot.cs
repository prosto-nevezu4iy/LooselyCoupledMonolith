﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BasketProject.Migrations
{
    [DbContext(typeof(BasketDbContext))]
    partial class BasketDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("basket")
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Basket.Contracts.Entities.Basket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<Guid>("BuyerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Baskets", "basket");
                });

            modelBuilder.Entity("Basket.Contracts.Entities.Basket", b =>
                {
                    b.OwnsMany("Basket.Contracts.Entities.BasketItem", "Items", b1 =>
                        {
                            b1.Property<int>("BasketId")
                                .HasColumnType("int");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"), 1L, 1);

                            b1.Property<int>("ProductId")
                                .HasColumnType("int");

                            b1.Property<byte>("Quantity")
                                .HasColumnType("tinyint");

                            b1.Property<decimal>("UnitPrice")
                                .HasPrecision(10, 2)
                                .HasColumnType("decimal(10,2)");

                            b1.HasKey("BasketId", "Id");

                            b1.ToTable("BasketItem", "basket");

                            b1.WithOwner()
                                .HasForeignKey("BasketId");
                        });

                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
