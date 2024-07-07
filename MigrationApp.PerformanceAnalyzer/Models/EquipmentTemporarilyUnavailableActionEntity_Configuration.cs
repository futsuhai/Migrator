using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class EquipmentTemporarilyUnavailableActionEntity_Configuration
    : IEntityTypeConfiguration<EquipmentTemporarilyUnavailableActionEntity>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<EquipmentTemporarilyUnavailableActionEntity> builder)
    {
        builder
            .HasOne(u => u.EquipmentAction)
            .WithOne();
    }
}