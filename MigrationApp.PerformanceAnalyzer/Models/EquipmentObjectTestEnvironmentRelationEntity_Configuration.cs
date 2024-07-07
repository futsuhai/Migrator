using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class EquipmentObjectTestEnvironmentRelationEntity_Configuration
    : IEntityTypeConfiguration<EquipmentObjectTestEnvironmentRelationEntity>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<EquipmentObjectTestEnvironmentRelationEntity> builder)
    {
        builder.HasAlternateKey(c => new { c.EquipmentId, c.ObjectTestEnvironmentId });

        builder.HasIndex(eoter => eoter.EquipmentId);
    }
}