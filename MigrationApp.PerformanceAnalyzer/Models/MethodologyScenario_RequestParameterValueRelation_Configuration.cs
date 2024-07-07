using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class MethodologyScenario_RequestParameterValueRelation_Configuration
    : IEntityTypeConfiguration<MethodologyScenario_RequestParameterValueRelation>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<MethodologyScenario_RequestParameterValueRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.MethodologyScenarioId, c.ParameterValueId });
    }
}