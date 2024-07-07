using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class ProductBuildReportParameterRelation_Configuration
    : IEntityTypeConfiguration<ProductBuildReportParameterRelation>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<ProductBuildReportParameterRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.ProductId, c.ParameterId });
    }
}