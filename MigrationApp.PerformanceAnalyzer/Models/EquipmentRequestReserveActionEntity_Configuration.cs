using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class EquipmentRequestReserveActionEntity_Configuration
    : IEntityTypeConfiguration<EquipmentRequestReserveActionEntity>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<EquipmentRequestReserveActionEntity> builder)
    {
        builder
            .HasOne(u => u.EquipmentAction)
            .WithOne();
    }
}