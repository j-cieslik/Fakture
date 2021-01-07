using Microsoft.EntityFrameworkCore;
using Models;

namespace API.Data
{
  public class StoreContext : DbContext
  {
    public StoreContext(DbContextOptions<StoreContext> options) : base(options)
    {
    }

    public DbSet<Fakture> Facture { get; set; }
    public DbSet<FaktureProducts> Products { get; set; }
    public DbSet<FaktureStatus> Status { get; set; }

  }
}
