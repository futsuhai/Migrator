using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class Configuration_ParameterValueRelation_Configuration
    : IEntityTypeConfiguration<Configuration_ParameterValueRelation>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<Configuration_ParameterValueRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.ConfigurationId, c.ParameterValueId });
    }
}