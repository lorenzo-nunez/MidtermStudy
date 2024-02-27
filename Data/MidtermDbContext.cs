using Microsoft.EntityFrameworkCore;
using MidtermStudy.Models;

namespace MidtermStudy.Data
{
    public class MidtermDbContext : DbContext
    {
        public MidtermDbContext(DbContextOptions<MidtermDbContext> options)
            :base(options)
        {
            
        }

        //Step 3 (Creating Model) STUDY GUIDE!!!!!
        public DbSet<Category> Categories { get; set; }

        //Step 4 (Creating model)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(

                new Category { 
                    Id = 1, 
                    Name = "Travel", 
                    Description = "Example stuff" },
                new Category { 
                    Id = 2, 
                    Name = "Fiction", 
                    Description = "Example stuff" },
                new Category { 
                    Id = 3, 
                    Name = "Non-Fiction", 
                    Description = "Example stuff" }
                );
        }
    }
}
