using Microsoft.EntityFrameworkCore;

namespace Refbooks.Persistence.EntityTypeConfigurationExtensions
{
    public static class CustomModelBuilderExtension
    {
        public static void RefbookConfigure<TEntity>(this ModelBuilder modelBuilder)
           where TEntity : class
        {
            foreach (var property in typeof(TEntity).GetProperties())
            {
                if (property.Name == "Id")
                {
                    modelBuilder.Entity<TEntity>().HasKey(property.Name);
                    modelBuilder.Entity<TEntity>().HasIndex(property.Name).IsUnique();
                }
                else if (property.PropertyType == typeof(DateTime?))
                {
                    modelBuilder.Entity<TEntity>()
                        .Property(property.Name)
                        .HasColumnType("date");
                }

            }
        }
    }
}
