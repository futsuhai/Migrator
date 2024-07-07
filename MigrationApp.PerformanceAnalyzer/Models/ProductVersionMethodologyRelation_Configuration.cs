using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
public class ProductVersionMethodologyRelation_Configuration : IEntityTypeConfiguration<ProductVersionMethodologyRelation>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<ProductVersionMethodologyRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.ProductVersionId, c.MethodologyId });
    }
}