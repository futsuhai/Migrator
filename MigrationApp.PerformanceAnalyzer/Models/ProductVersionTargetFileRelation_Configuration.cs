using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class ProductVersionTargetFileRelation_Configuration
    : IEntityTypeConfiguration<ProductVersionTargetFileRelation>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<ProductVersionTargetFileRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.ProductVersionId, c.StorageFileId });
    }
}