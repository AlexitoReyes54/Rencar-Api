// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using rentCar.Models;

namespace rentCar.Migrations
{
    [DbContext(typeof(CarStuffContext))]
    [Migration("20210917224230_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

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
