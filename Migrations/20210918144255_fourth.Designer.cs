﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using rentCar.Models;

namespace rentCar.Migrations
{
    [DbContext(typeof(CarStuffContext))]
    [Migration("20210918144255_fourth")]
    partial class fourth
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("rentCar.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CarType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ChasisNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("EngineNumber")
                        .HasColumnType("TEXT");

                    b.Property<int>("FuelType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Mark")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Model")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Plate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("able")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("cars");
                });

            modelBuilder.Entity("rentCar.Models.CarType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("able")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("carTypes");
                });

            modelBuilder.Entity("rentCar.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreditCard")
                        .HasColumnType("TEXT");

                    b.Property<int>("CreditLimit")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Identificacion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonType")
                        .HasColumnType("TEXT");

                    b.Property<bool>("able")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("clients");
                });

            modelBuilder.Entity("rentCar.Models.FuelType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("able")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("fuelTypes");
                });

            modelBuilder.Entity("rentCar.Models.Mark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("able")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Marks");
                });

            modelBuilder.Entity("rentCar.Models.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("MarkId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("able")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("models");
                });
#pragma warning restore 612, 618
        }
    }
}
