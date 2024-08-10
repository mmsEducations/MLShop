using Microsoft.EntityFrameworkCore;
using MLShop.Data.Entities;
using MLShop.Data.Extensions;

namespace MLShop.Data
{
    public class MShopContext : DbContext
    {
        public MShopContext()
        {

        }
        public MShopContext(DbContextOptions<MShopContext> options) : base(options)
        {

        }

        //DB Tables 
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.HasDefaultSchema("mlshop");

            ////Entity Configuration class added 
            modelBuilder.AddEntityConfiguration();

            ////Dummy data Created
            modelBuilder.CreateSeedData();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Host=localhost;Database=postgres;Username=postgres;Password=mms;Search Path=mlshop");
        }

    }
}

