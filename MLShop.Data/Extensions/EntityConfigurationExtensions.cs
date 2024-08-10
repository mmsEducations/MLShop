using Microsoft.EntityFrameworkCore;
using MLShop.Data.Configurations;

namespace MLShop.Data.Extensions
{
    public static class EntityConfigurationExtensions
    {
        public static void AddEntityConfiguration(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        }
    }
}
