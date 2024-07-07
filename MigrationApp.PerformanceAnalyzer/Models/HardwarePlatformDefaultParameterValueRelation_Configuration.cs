using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class HardwarePlatformDefaultParameterValueRelation_Configuration
    : IEntityTypeConfiguration<HardwarePlatformDefaultParameterValueRelation>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<HardwarePlatformDefaultParameterValueRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.HardwarePlatformId, c.ParameterValueId });
    }
}