using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class ProductFeatureSetRelationEntity_Configuration
    : IEntityTypeConfiguration<ProductFeatureSetRelationEntity>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<ProductFeatureSetRelationEntity> builder)
    {
        builder.HasAlternateKey(c => new { c.ProductId, c.FeatureSetId });
    }
}