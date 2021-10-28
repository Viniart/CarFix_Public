using CarFix.Project.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarFix.Project.Contexts
{
    public class CarFixContext : DbContext
    {
        public CarFixContext(DbContextOptions<CarFixContext> options) : base(options)
        {

        }

        // Tables
        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceImage> ServiceImages { get; set; }

        // Modelling
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Users
            modelBuilder.Entity<User>().ToTable("Users");

            modelBuilder.Entity<User>().Property(x => x.Id);

            modelBuilder.Entity<User>().Property(x => x.Username).HasMaxLength(30);
            modelBuilder.Entity<User>().Property(x => x.Username).HasColumnType("varchar(30)");
            modelBuilder.Entity<User>().Property(x => x.Username).IsRequired();

            modelBuilder.Entity<User>().Property(x => x.Email).HasMaxLength(60);
            modelBuilder.Entity<User>().Property(x => x.Email).HasColumnType("varchar(60)");
            modelBuilder.Entity<User>().Property(x => x.Email).IsRequired();

            modelBuilder.Entity<User>().Property(x => x.Password).HasMaxLength(200);
            modelBuilder.Entity<User>().Property(x => x.Password).HasColumnType("varchar(200)");
            modelBuilder.Entity<User>().Property(x => x.Password).IsRequired();

            modelBuilder.Entity<User>().Property(x => x.PhoneNumber).HasMaxLength(30);
            modelBuilder.Entity<User>().Property(x => x.PhoneNumber).HasColumnType("varchar(30)");
            modelBuilder.Entity<User>().Property(x => x.PhoneNumber).IsRequired();

            modelBuilder.Entity<User>().Property(x => x.UserType).HasMaxLength(20);
            modelBuilder.Entity<User>().Property(x => x.UserType).HasColumnType("varchar(20)");
            modelBuilder.Entity<User>().Property(x => x.UserType).IsRequired();

            

            modelBuilder.Entity<User>().Property(x => x.CreationDate).HasColumnType("DateTime");
            #endregion

            #region Vehicles
            modelBuilder.Entity<Vehicle>().ToTable("Vehicles");/ 

            modelBuilder.Entity<Vehicle>().Property(x => x.Id);

            modelBuilder.Entity<Vehicle>().Property(x => x.LicensePlate).HasMaxLength(30);
            modelBuilder.Entity<Vehicle>().Property(x => x.LicensePlate).HasColumnType("varchar(30)");
            modelBuilder.Entity<Vehicle>().Property(x => x.LicensePlate).IsRequired();

            modelBuilder.Entity<Vehicle>().Property(x => x.ModelName).HasMaxLength(60);
            modelBuilder.Entity<Vehicle>().Property(x => x.ModelName).HasColumnType("varchar(60)");
            modelBuilder.Entity<Vehicle>().Property(x => x.ModelName).IsRequired();

            modelBuilder.Entity<Vehicle>().Property(x => x.BrandName).HasMaxLength(50);
            modelBuilder.Entity<Vehicle>().Property(x => x.BrandName).HasColumnType("varchar(50)");
            modelBuilder.Entity<Vehicle>().Property(x => x.BrandName).IsRequired();

            modelBuilder.Entity<Vehicle>().Property(x => x.Year).HasColumnType("int");
            modelBuilder.Entity<Vehicle>().Property(x => x.Year).IsRequired();

            modelBuilder.Entity<Vehicle>().Property(x => x.Color).HasMaxLength(20);
            modelBuilder.Entity<Vehicle>().Property(x => x.Color).HasColumnType("varchar(20)");
            modelBuilder.Entity<Vehicle>().Property(x => x.Color).IsRequired();

            modelBuilder.Entity<Vehicle>().Property(x => x.VehicleImage).HasMaxLength(200);
            modelBuilder.Entity<Vehicle>().Property(x => x.VehicleImage).HasColumnType("varchar(200)");

            modelBuilder.Entity<Vehicle>()
                .HasOne(u => u.User)
                .WithMany(v => v.Vehicles)
                .HasForeignKey(f => f.IdUser);

            #endregion
            
            #region Budgets
            modelBuilder.Entity<Budget>().ToTable("Budgets");

            modelBuilder.Entity<Budget>().Property(x => x.Id);

            modelBuilder.Entity<Budget>().Property(x => x.TotalValue).HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Budget>().Property(x => x.TimeEstimate).HasColumnType("int");

            modelBuilder.Entity<Budget>().Property(x => x.VisitDate).HasColumnType("datetime");

            modelBuilder.Entity<Budget>().Property(x => x.FinalizationDate).HasColumnType("datetime");

            modelBuilder.Entity<Budget>().Property(x => x.CreationDate).HasColumnType("DateTime");

            modelBuilder.Entity<Budget>()
                .HasOne<Vehicle>(u => u.Vehicle)
                .WithOne(b => b.Budget)
                .HasForeignKey<Budget>(f => f.IdVehicle);

            #endregion

            #region ServiceTypes
            modelBuilder.Entity<Budget>().ToTable("ServiceTypes");

            modelBuilder.Entity<Budget>().Property(x => x.Id);

            modelBuilder.Entity<Budget>().Property(x => x.TotalValue).HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Budget>().Property(x => x.TimeEstimate).HasColumnType("int");

            modelBuilder.Entity<Budget>().Property(x => x.VisitDate).HasColumnType("datetime");

            modelBuilder.Entity<Budget>().Property(x => x.FinalizationDate).HasColumnType("datetime");

            modelBuilder.Entity<Budget>().Property(x => x.CreationDate).HasColumnType("DateTime");

            modelBuilder.Entity<Budget>()
                .HasOne<Vehicle>(u => u.Vehicle)
                .WithOne(b => b.Budget)
                .HasForeignKey<Budget>(f => f.IdVehicle);

            #endregion

            #region Services
            modelBuilder.Entity<Budget>().ToTable("Services");

            modelBuilder.Entity<Budget>().Property(x => x.Id);

            modelBuilder.Entity<Budget>().Property(x => x.TotalValue).HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Budget>().Property(x => x.TimeEstimate).HasColumnType("int");

            modelBuilder.Entity<Budget>().Property(x => x.VisitDate).HasColumnType("datetime");

            modelBuilder.Entity<Budget>().Property(x => x.FinalizationDate).HasColumnType("datetime");

            modelBuilder.Entity<Budget>().Property(x => x.CreationDate).HasColumnType("DateTime");

            modelBuilder.Entity<Budget>()
                .HasOne<Vehicle>(u => u.Vehicle)
                .WithOne(b => b.Budget)
                .HasForeignKey<Budget>(f => f.IdVehicle);

            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
