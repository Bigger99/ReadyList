using Microsoft.EntityFrameworkCore;
using ReadyList.Database.Models;

namespace ReadyList.Database.Context
{
    public class DatabaseContext : DbContext
    {
        #region Tables

        public DbSet<User> Users { get; set; }
        public DbSet<Issue> Issues { get; set; }

        #endregion

        public DatabaseContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=ready_list;Username=postgres;Password=123");
        }
    }
}
