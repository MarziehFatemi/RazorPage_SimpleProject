using Microsoft.EntityFrameworkCore;
using RazorBlog.Mapping;
using RazorBlog.Models;

namespace RazorBlog.Context
{
    public class RazorBlog_dbContext : DbContext
    {
        public RazorBlog_dbContext(DbContextOptions<RazorBlog_dbContext> options) : base(options)
        {
        }
       
        public DbSet<Project> Projects { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            modelBuilder.ApplyConfiguration(new ProjectMapping());
            base.OnModelCreating(modelBuilder);
        }

    }
}
