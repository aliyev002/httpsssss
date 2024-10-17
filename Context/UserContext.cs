using HttpRequestDB.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpRequestDB.Context
{
    internal class UserContext
    {
        public class BusContext : DbContext
        {

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Data Source = STHQ0118-07;User ID=admin;Password=admin; Database=Users;TrustServerCertificate=True");
            }
            public DbSet<User> Users { get; set; }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<User>().ToTable("users");
            }
        }
    }
}
