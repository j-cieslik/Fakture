using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace API.Data.Config
{
  public class FactureConfiguration : IEntityTypeConfiguration<Fakture>
  {
    public void Configure(EntityTypeBuilder<Fakture> builder)
    {
      builder.Property(p => p.Id).IsRequired();
      builder.Property(p => p.Date).IsRequired();
      builder.Property(p => p.City).IsRequired().HasMaxLength(100);
      builder.HasOne(p => p.FaktureProducts).WithMany()
            .HasForeignKey(p => p.FaktureProductsId);
      builder.HasOne(p => p.FaktureStatus).WithMany()
            .HasForeignKey(p => p.FaktureStatusId);
    }
  }
}