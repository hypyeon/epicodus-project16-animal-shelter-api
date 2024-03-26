﻿// <auto-generated />
using AnimalShelterApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AnimalShelterApi.Migrations
{
    [DbContext(typeof(AnimalShelterApiContext))]
    [Migration("20240326051310_AddCatData")]
    partial class AddCatData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelterApi.Models.Cat", b =>
                {
                    b.Property<int>("CatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<bool>("NeuteredSpayed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Sex")
                        .HasColumnType("longtext");

                    b.HasKey("CatId");

                    b.ToTable("Cats");

                    b.HasData(
                        new
                        {
                            CatId = 1,
                            Name = "Orzo",
                            NeuteredSpayed = true,
                            Sex = "Male"
                        },
                        new
                        {
                            CatId = 2,
                            Name = "Luna",
                            NeuteredSpayed = true,
                            Sex = "Female"
                        },
                        new
                        {
                            CatId = 3,
                            Name = "Starling",
                            NeuteredSpayed = true,
                            Sex = "Female"
                        },
                        new
                        {
                            CatId = 4,
                            Name = "Elvie",
                            NeuteredSpayed = true,
                            Sex = "Female"
                        });
                });

            modelBuilder.Entity("AnimalShelterApi.Models.Dog", b =>
                {
                    b.Property<int>("DogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Age")
                        .HasColumnType("longtext");

                    b.Property<string>("Breed")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<bool>("NeuteredSpayed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Sex")
                        .HasColumnType("longtext");

                    b.HasKey("DogId");

                    b.ToTable("Dogs");

                    b.HasData(
                        new
                        {
                            DogId = 1,
                            Age = "3 years (estimate)",
                            Breed = "Australian Cattle Dog mix",
                            Name = "Beanie",
                            NeuteredSpayed = true,
                            Sex = "Male"
                        },
                        new
                        {
                            DogId = 2,
                            Age = "Unknown",
                            Breed = "American Staffordshire Terrier mix",
                            Name = "Bronx",
                            NeuteredSpayed = true,
                            Sex = "Male"
                        },
                        new
                        {
                            DogId = 3,
                            Age = "2 years (estimate)",
                            Breed = "American Staffordshire Terrir mix",
                            Name = "Russell",
                            NeuteredSpayed = true,
                            Sex = "Male"
                        },
                        new
                        {
                            DogId = 4,
                            Age = "9 months",
                            Breed = "Bull Terrier mix",
                            Name = "Two",
                            NeuteredSpayed = true,
                            Sex = "Female"
                        },
                        new
                        {
                            DogId = 5,
                            Age = "18 months",
                            Breed = "Belgian Shepherd mix",
                            Name = "Loverboy",
                            NeuteredSpayed = true,
                            Sex = "Male"
                        },
                        new
                        {
                            DogId = 6,
                            Age = "2 years (estimate)",
                            Breed = "Border Collie mix",
                            Name = "Hera",
                            NeuteredSpayed = true,
                            Sex = "Female"
                        },
                        new
                        {
                            DogId = 7,
                            Age = "8 weeks",
                            Breed = "Dachshund mix",
                            Name = "Burrito",
                            NeuteredSpayed = false,
                            Sex = "Female"
                        },
                        new
                        {
                            DogId = 8,
                            Age = "4 years (estimate)",
                            Breed = "Husky mix",
                            Name = "King",
                            NeuteredSpayed = true
                        });
                });
#pragma warning restore 612, 618
        }
    }
}