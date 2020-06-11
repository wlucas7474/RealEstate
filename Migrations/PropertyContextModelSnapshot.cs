﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RealEstateWebApp.Data;

namespace RealEstateWebApp.Migrations
{
    [DbContext(typeof(PropertyContext))]
    partial class PropertyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RealEstateWebApp.Models.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AttachedGarage")
                        .HasColumnType("bit");

                    b.Property<string>("Cooling")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Electric")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Flooring")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HasBasement")
                        .HasColumnType("bit");

                    b.Property<string>("Heating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Internet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsStudio")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LatestRenovationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LatestRenovationDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("LotSize")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NumBaths")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("NumBeds")
                        .HasColumnType("int");

                    b.Property<int>("NumGarageSpots")
                        .HasColumnType("int");

                    b.Property<int>("NumParkingSpots")
                        .HasColumnType("int");

                    b.Property<int>("NumStories")
                        .HasColumnType("int");

                    b.Property<string>("OtherDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sewer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<string>("TV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("YearBuilt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Property");
                });
#pragma warning restore 612, 618
        }
    }
}
