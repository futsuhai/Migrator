using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class MethodologyHardwarePlatformRelation_Configuration
    : IEntityTypeConfiguration<MethodologyHardwarePlatformRelation>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<MethodologyHardwarePlatformRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.MethodologyId, c.HardwarePlatformId });
    }
}