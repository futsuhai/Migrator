using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
public class ProductVersionMethodologyBundleRelation_Configuration : IEntityTypeConfiguration<ProductVersionMethodologyBundleRelation>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<ProductVersionMethodologyBundleRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.ProductVersionId, c.MethodologyBundleId });
    }
}