using CalorieCoach.DAL.Entities;
using CalorieCoach.DAL.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCoach.DAL.Data
{
    public class CalorieCoachDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Food> Foods { get; set; }

        public DbSet<FoodCategory> FoodCategories { get; set; }

        public DbSet<FoodPortion> FoodPortions{ get; set; }

        public DbSet<MealRecord> MealRecords { get; set; }

        public DbSet<Report> Reports { get; set; }
        //public DbSet<MealType> MealTypes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            //  optionsBuilder.UseSqlServer
            //  ("Server=SENANURKURTKAYA\\SQLEXPRESS;Database=CalorieCoachDb;Trustservercertificate=true;Trusted_Connection=true;");
            
                var connectionString = "Server=SENANURKURTKAYA\\SQLEXPRESS;Database=CalorieCoachDb;TrustServerCertificate=true;Trusted_Connection=true;";
                optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }




        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<User>().HasIndex(x => x.Email).IsUnique();


        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var UserEntity =modelBuilder.Entity<User>();

            UserEntity.HasKey(x => x.Id);
            UserEntity.Property(x => x.Id).UseIdentityColumn();
            UserEntity.HasIndex(x => x.Email).IsUnique();
           
            var foodCategory = modelBuilder.Entity<FoodCategory>();

            foodCategory.HasKey(x=>x.Id);   
            foodCategory.Property(x =>x.Id).UseIdentityColumn();
            foodCategory.HasIndex(x=>x.CategoryName).IsUnique();

            var foodEntity = modelBuilder.Entity<Food>();

            foodEntity.HasKey(x=>x.Id);
            foodEntity.Property(x=>x.Id).UseIdentityColumn();
            foodEntity.HasOne(x => x.Category)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            var mealRecordEntity = modelBuilder.Entity<MealRecord>();

            mealRecordEntity.HasKey(x => x.Id);
            mealRecordEntity.Property(x => x.Id).UseIdentityColumn();

            mealRecordEntity.HasOne(x => x.User)
                .WithMany(x => x.MealRecords)
                .OnDelete(DeleteBehavior.Cascade);

            var foodPortionEntity = modelBuilder.Entity<FoodPortion>();

            foodPortionEntity.HasKey(x => x.Id);
            foodPortionEntity.Property(x => x.Id).UseIdentityColumn();

            foodPortionEntity.HasOne(x => x.MealRecord)
                .WithMany(x => x.Portions)
                .OnDelete(DeleteBehavior.Cascade);

            foodPortionEntity.HasOne(x => x.Food)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }

    }
}
