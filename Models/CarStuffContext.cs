using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using rentCar.Models;


namespace rentCar.Models
{
    public class CarStuffContext : DbContext
    {
        public DbSet<Mark> Marks { get; set; }
        public DbSet<CarType> carTypes { get; set; }
        public DbSet<Model> models { get; set; }
        public DbSet<FuelType> fuelTypes { get; set; }
        

        public string DbPath { get; private set; }

        public CarStuffContext()
        {
            var path = Environment.CurrentDirectory;
            DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}CarStuffContext.db";
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    } 
}