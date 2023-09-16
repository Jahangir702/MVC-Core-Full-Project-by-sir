﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using R54_M10_Class_01_Work_01.Models;

#nullable disable

namespace R54_M10_Class_01_Work_01.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    partial class ProductDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("R54_M10_Class_01_Work_01.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("SellUnit")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("money");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Name = "P01",
                            Picture = "1.jpg",
                            SellUnit = 1,
                            UnitPrice = 950.00m
                        },
                        new
                        {
                            ProductId = 2,
                            Name = "P02",
                            Picture = "2.jpg",
                            SellUnit = 1,
                            UnitPrice = 1900.00m
                        },
                        new
                        {
                            ProductId = 3,
                            Name = "P03",
                            Picture = "3.jpg",
                            SellUnit = 1,
                            UnitPrice = 2850.00m
                        },
                        new
                        {
                            ProductId = 4,
                            Name = "P04",
                            Picture = "4.jpg",
                            SellUnit = 1,
                            UnitPrice = 3800.00m
                        },
                        new
                        {
                            ProductId = 5,
                            Name = "P05",
                            Picture = "5.jpg",
                            SellUnit = 1,
                            UnitPrice = 4750.00m
                        },
                        new
                        {
                            ProductId = 6,
                            Name = "P06",
                            Picture = "6.jpg",
                            SellUnit = 1,
                            UnitPrice = 5700.00m
                        },
                        new
                        {
                            ProductId = 7,
                            Name = "P07",
                            Picture = "7.jpg",
                            SellUnit = 1,
                            UnitPrice = 6650.00m
                        });
                });

            modelBuilder.Entity("R54_M10_Class_01_Work_01.Models.ProductInventory", b =>
                {
                    b.Property<int>("ProductInventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductInventoryId"));

                    b.Property<DateTime?>("Date")
                        .IsRequired()
                        .HasColumnType("date");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("Quantity")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("ProductInventoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductInventories");

                    b.HasData(
                        new
                        {
                            ProductInventoryId = 1,
                            Date = new DateTime(2023, 8, 23, 12, 41, 14, 760, DateTimeKind.Local).AddTicks(8476),
                            ProductId = 1,
                            Quantity = 50
                        },
                        new
                        {
                            ProductInventoryId = 2,
                            Date = new DateTime(2023, 7, 31, 12, 41, 14, 760, DateTimeKind.Local).AddTicks(8524),
                            ProductId = 2,
                            Quantity = 100
                        },
                        new
                        {
                            ProductInventoryId = 3,
                            Date = new DateTime(2023, 7, 8, 12, 41, 14, 760, DateTimeKind.Local).AddTicks(8538),
                            ProductId = 3,
                            Quantity = 150
                        },
                        new
                        {
                            ProductInventoryId = 4,
                            Date = new DateTime(2023, 6, 15, 12, 41, 14, 760, DateTimeKind.Local).AddTicks(8551),
                            ProductId = 4,
                            Quantity = 200
                        },
                        new
                        {
                            ProductInventoryId = 5,
                            Date = new DateTime(2023, 5, 23, 12, 41, 14, 760, DateTimeKind.Local).AddTicks(8565),
                            ProductId = 5,
                            Quantity = 250
                        },
                        new
                        {
                            ProductInventoryId = 6,
                            Date = new DateTime(2023, 4, 30, 12, 41, 14, 760, DateTimeKind.Local).AddTicks(8579),
                            ProductId = 6,
                            Quantity = 300
                        },
                        new
                        {
                            ProductInventoryId = 7,
                            Date = new DateTime(2023, 4, 7, 12, 41, 14, 760, DateTimeKind.Local).AddTicks(8593),
                            ProductId = 7,
                            Quantity = 350
                        },
                        new
                        {
                            ProductInventoryId = 8,
                            Date = new DateTime(2023, 3, 15, 12, 41, 14, 760, DateTimeKind.Local).AddTicks(8606),
                            ProductId = 1,
                            Quantity = 400
                        },
                        new
                        {
                            ProductInventoryId = 9,
                            Date = new DateTime(2023, 2, 20, 12, 41, 14, 760, DateTimeKind.Local).AddTicks(8622),
                            ProductId = 2,
                            Quantity = 450
                        },
                        new
                        {
                            ProductInventoryId = 10,
                            Date = new DateTime(2023, 1, 28, 12, 41, 14, 760, DateTimeKind.Local).AddTicks(8638),
                            ProductId = 3,
                            Quantity = 500
                        });
                });

            modelBuilder.Entity("R54_M10_Class_01_Work_01.Models.ProductInventory", b =>
                {
                    b.HasOne("R54_M10_Class_01_Work_01.Models.Product", "Product")
                        .WithMany("ProductInventories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("R54_M10_Class_01_Work_01.Models.Product", b =>
                {
                    b.Navigation("ProductInventories");
                });
#pragma warning restore 612, 618
        }
    }
}
