using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class HardwarePlatformParameterValueRelation_Configuration
    : IEntityTypeConfiguration<HardwarePlatformParameterValueRelation>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<HardwarePlatformParameterValueRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.HardwarePlatformId, c.ParameterValueId });

        builder.HasIndex(hppvr => new
        {
            hppvr.HardwarePlatformId,
            hppvr.ParameterValueId,
            hppvr.Id,
        });
    }
}