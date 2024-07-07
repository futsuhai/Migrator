using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
public class ProductVersionTargetSetEntityConfiguration : IEntityTypeConfiguration<ProductVersionTargetSetEntity>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<ProductVersionTargetSetEntity> builder)
    {
        builder.HasIndex(pvts => pvts.ProductVersionName).IsUnique();
    }
}