using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class ProductVersionOperationSystemRelation_Configuration
    : IEntityTypeConfiguration<ProductVersionOperationSystemRelation>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<ProductVersionOperationSystemRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.ProductVersionId, c.OperationSystemId });
    }
}