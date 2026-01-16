using App.BL.Data.DbModels;
using Microsoft.EntityFrameworkCore;

namespace App.BL.Data
{
        public class AppDbContext : DbContext
        {
            private string _connectionString = "Host=localhost;Port=5432;Database=ProjectsLibraryDB;Username=postgres;Password=admin";
            public DbSet<UserDbModel> Users => Set<UserDbModel>();

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseNpgsql(_connectionString);
            }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                
            }
        }
    }
