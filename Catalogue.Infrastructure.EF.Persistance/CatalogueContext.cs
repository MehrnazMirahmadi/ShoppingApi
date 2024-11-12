using Catalogue.DomainModel.Models;
using Microsoft.EntityFrameworkCore;

namespace Catalogue.Infrastructure.EF.Persistance
{
    public class CatalogueContext : DbContext
    {
        public CatalogueContext(DbContextOptions<CatalogueContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().Property(c => c.CategoryName).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Category>().Property(c => c.Slug).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Category>().Property(c => c.LineAge).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Children)
                .WithOne(c => c.Parent)
                .HasForeignKey(c => c.ParentID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(c => c.Category)
                .HasForeignKey(c => c.CategoryID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Category>()
                .HasMany(c => c.CategoryFeatures)
                .WithOne(c => c.Category)
                .HasForeignKey(c => c.CategoryID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Category>().ToTable("Category");

            modelBuilder.Entity<Product>().Property(p => p.ProductName).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Product>().Property(p => p.SmallDescription).IsRequired().HasMaxLength(400);
            modelBuilder.Entity<Product>().Property(p => p.Slug).IsRequired().HasMaxLength(100);

            modelBuilder.Entity<Product>().Property(p => p.Alt).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Product>()
                .HasMany(p => p.ProductFeatures)
                .WithOne(p => p.Product)
                .HasForeignKey(p => p.ProductID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Product>().ToTable("Product");

            modelBuilder.Entity<CategoryFeature>()
                .HasKey(cf => new { cf.Category, cf.FeatureID });
            modelBuilder.Entity<CategoryFeature>().ToTable("CategoryFeature");

            modelBuilder.Entity<ProductFeature>()
                .HasKey(pf => new { pf.Product, pf.FeatureID });
            modelBuilder.Entity<ProductFeature>().ToTable("ProductFeature");
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryFeature> CategoryFeatures { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
        public DbSet<ProductMedia> ProductMedia { get; set; }
        public DbSet<ProductMediaType> ProductMediaTypes { get; set; }

    }
}
