using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class MethodologyStandSchemeParameterValueRelation_Configuration
    : IEntityTypeConfiguration<MethodologyStandSchemeParameterValueRelation>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<MethodologyStandSchemeParameterValueRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.MethodologyStandSchemeId, c.ParameterValueId });
    }
}