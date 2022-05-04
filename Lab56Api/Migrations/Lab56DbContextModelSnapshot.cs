﻿// <auto-generated />
using Lab56Api.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lab56Api.Migrations
{
    [DbContext(typeof(Lab56DbContext))]
    partial class Lab56DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Lab56Api.Model.Lab56Item", b =>
                {
                    b.Property<uint>("Lab56ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .HasColumnType("longtext");

                    b.Property<string>("Lat")
                        .HasColumnType("longtext");

                    b.Property<string>("Lng")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("PostCode")
                        .HasColumnType("longtext");

                    b.Property<string>("Region")
                        .HasColumnType("longtext");

                    b.Property<string>("StreetNo")
                        .HasColumnType("longtext");

                    b.HasKey("Lab56ItemId");

                    b.ToTable("Lab56Items");
                });
#pragma warning restore 612, 618
        }
    }
}
