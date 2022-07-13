using BackEndAssignment.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEndAssignment.Context
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite(@"DataSource=mydatabase.db;");
        }


        #region DB Sets

        public DbSet<Author> Authors { get; set; }

        #endregion
    }
}
