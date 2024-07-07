using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class EquipmentHardwarePlatformRelationEntity_Configuration
    : IEntityTypeConfiguration<EquipmentHardwarePlatformRelationEntity>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<EquipmentHardwarePlatformRelationEntity> builder)
    {
        builder.HasAlternateKey(c => new { c.EquipmentId, c.HardwarePlatformId });

        NpgsqlIndexBuilderExtensions.IncludeProperties(
            builder.HasIndex(ehpr => ehpr.EquipmentId),
            ehpr => new object[] { ehpr.HardwarePlatformId });
    }
}