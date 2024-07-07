using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class MethodologyParameterProductVisibilityRelation_Configuration
    : IEntityTypeConfiguration<MethodologyParameterProductVisibilityRelation>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<MethodologyParameterProductVisibilityRelation> builder)
    {
        builder
            .HasAlternateKey(c => new { c.MethodologyParameterRelationId, c.ProductId });
    }
}