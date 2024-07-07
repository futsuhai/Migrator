using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
public class ProductVersionParameterValueRelation_Configuration : IEntityTypeConfiguration<ProductVersionParameterValueRelation>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<ProductVersionParameterValueRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.ProductVersionId, c.ParameterValueId });

        builder.HasIndex(e => e.ParameterValueId);

        builder.HasIndex(pvpvr => new
        {
            pvpvr.ParameterValueId,
            pvpvr.ProductVersionId,
            pvpvr.Id,
        });
    }
}