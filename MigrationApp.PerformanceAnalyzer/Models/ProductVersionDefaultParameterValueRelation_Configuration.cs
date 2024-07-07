using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
public class ProductVersionDefaultParameterValueRelation_Configuration : IEntityTypeConfiguration<ProductVersionDefaultParameterValueRelation>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<ProductVersionDefaultParameterValueRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.ProductVersionId, c.ParameterValueId });
    }
}