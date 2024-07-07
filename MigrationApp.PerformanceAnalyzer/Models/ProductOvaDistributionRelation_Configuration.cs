using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
public class ProductOvaDistributionRelation_Configuration : IEntityTypeConfiguration<ProductOvaDistributionRelation>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<ProductOvaDistributionRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.ProductId, c.OvaDistributionId });
    }
}