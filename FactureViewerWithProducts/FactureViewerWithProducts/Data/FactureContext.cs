using FactureViewerWithProducts.Models;
using Microsoft.EntityFrameworkCore;

namespace FactureViewerWithProducts.Data
{
	public class FactureContext : DbContext
	{
		public FactureContext(DbContextOptions<FactureContext> options) : base(options)
		{

		}

		public DbSet<Facture> Factures { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Status> Statuses { get; set; }
		public DbSet<FactureProducts> FactureProducts { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<FactureProducts>()
					.HasKey(bc => new { bc.Id });
			modelBuilder.Entity<FactureProducts>()
					.HasOne(bc => bc.Facture)
					.WithMany(b => b.FactureProducts)
					.HasForeignKey(bc => bc.FactureId);
			modelBuilder.Entity<FactureProducts>()
					.HasOne(bc => bc.Product)
					.WithMany(c => c.FactureProducts)
					.HasForeignKey(bc => bc.ProductId);
		}
	}
}