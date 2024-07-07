using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class HardwarePlatformOperationSystemRelation_Configuration
    : IEntityTypeConfiguration<HardwarePlatformOperationSystemRelation>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<HardwarePlatformOperationSystemRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.HardwarePlatformId, c.OperationSystemId });
    }
}