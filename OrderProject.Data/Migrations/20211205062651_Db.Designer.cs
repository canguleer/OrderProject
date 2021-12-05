﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderProject.Data;

namespace OrderProject.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211205062651_Db")]
    partial class Db
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OrderProject.Core.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("StoreName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Order", "dbo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 3,
                            CreatedOn = new DateTime(2021, 12, 5, 9, 26, 50, 552, DateTimeKind.Local).AddTicks(1608),
                            CustomerName = "Can Güler",
                            Price = 17m,
                            Status = 10,
                            StoreName = "Shopi"
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 5,
                            CreatedOn = new DateTime(2021, 11, 25, 9, 26, 50, 554, DateTimeKind.Local).AddTicks(9771),
                            CustomerName = "Mehmet Güler",
                            Price = 55m,
                            Status = 50,
                            StoreName = "Shopi"
                        },
                        new
                        {
                            Id = 3,
                            BrandId = 2,
                            CreatedOn = new DateTime(2021, 10, 16, 9, 26, 50, 555, DateTimeKind.Local).AddTicks(39),
                            CustomerName = "Ahmet Güler",
                            Price = 60m,
                            Status = 30,
                            StoreName = "Shopi"
                        },
                        new
                        {
                            Id = 4,
                            BrandId = 2,
                            CreatedOn = new DateTime(2021, 11, 25, 9, 26, 50, 555, DateTimeKind.Local).AddTicks(55),
                            CustomerName = "Feyza Güler",
                            Price = 90m,
                            Status = 40,
                            StoreName = "Shopi"
                        },
                        new
                        {
                            Id = 5,
                            BrandId = 8,
                            CreatedOn = new DateTime(2021, 11, 30, 9, 26, 50, 555, DateTimeKind.Local).AddTicks(61),
                            CustomerName = "Enise Güler",
                            Price = 70m,
                            Status = 10,
                            StoreName = "Shopi"
                        },
                        new
                        {
                            Id = 6,
                            BrandId = 7,
                            CreatedOn = new DateTime(2021, 11, 26, 9, 26, 50, 555, DateTimeKind.Local).AddTicks(76),
                            CustomerName = "Adem Güler",
                            Price = 50m,
                            Status = 20,
                            StoreName = "Shopi"
                        },
                        new
                        {
                            Id = 7,
                            BrandId = 6,
                            CreatedOn = new DateTime(2021, 10, 1, 9, 26, 50, 555, DateTimeKind.Local).AddTicks(82),
                            CustomerName = "Şimşek Güler",
                            Price = 220m,
                            Status = 10,
                            StoreName = "Shopi"
                        },
                        new
                        {
                            Id = 8,
                            BrandId = 5,
                            CreatedOn = new DateTime(2021, 9, 8, 9, 26, 50, 555, DateTimeKind.Local).AddTicks(88),
                            CustomerName = "Abdullah Güler",
                            Price = 87m,
                            Status = 10,
                            StoreName = "Shopi"
                        },
                        new
                        {
                            Id = 9,
                            BrandId = 21,
                            CreatedOn = new DateTime(2021, 11, 24, 9, 26, 50, 555, DateTimeKind.Local).AddTicks(94),
                            CustomerName = "Nurullah Güler",
                            Price = 65m,
                            Status = 10,
                            StoreName = "Shopi"
                        },
                        new
                        {
                            Id = 10,
                            BrandId = 14,
                            CreatedOn = new DateTime(2021, 11, 28, 9, 26, 50, 555, DateTimeKind.Local).AddTicks(102),
                            CustomerName = "Enes Güler",
                            Price = 65m,
                            Status = 10,
                            StoreName = "Shopi"
                        },
                        new
                        {
                            Id = 11,
                            BrandId = 2,
                            CreatedOn = new DateTime(2021, 11, 25, 9, 26, 50, 555, DateTimeKind.Local).AddTicks(108),
                            CustomerName = "Emel Güler",
                            Price = 87m,
                            Status = 10,
                            StoreName = "Shopi"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}