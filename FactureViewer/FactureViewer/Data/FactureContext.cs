using FactureViewer.Models;
using Microsoft.EntityFrameworkCore;

namespace FactureViewer.Data
{
    public class FactureContext : DbContext
    {
        public FactureContext(DbContextOptions<FactureContext> options) : base(options)
				{
						
				}

				public DbSet<Facture> Factures { get; set; }
				public DbSet<Product> Products { get; set; }
				public DbSet<Status> Statuses { get; set; }

				protected override void OnModelCreating(ModelBuilder modelBuilder)
				{
					modelBuilder.Entity<Facture>()
													.HasOne(a => a.Product).WithOne(b => b.Facture)
													.HasForeignKey<Product>(b => b.Id);
					// modelBuilder.Entity<Product>()
					// 					.HasOne(a => a.Facture).WithOne(b => b.Product)
					// 					.HasForeignKey<Facture>(b => b.Id);
					modelBuilder.Entity<Status>().ToTable("Status");
					modelBuilder.Entity<Product>().ToTable("Product");
				}
    }
}