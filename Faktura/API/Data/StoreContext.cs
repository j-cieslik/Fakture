using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Models;

namespace API.Data
{
  public class StoreContext : DbContext
  {
    public StoreContext(DbContextOptions<StoreContext> options) : base(options)
    {
    }

    public DbSet<Fakture> Fakture { get; set; }
    public DbSet<FaktureProducts> FaktureProducts { get; set; }
    public DbSet<FaktureStatus> FaktureStatus { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
  }
}
