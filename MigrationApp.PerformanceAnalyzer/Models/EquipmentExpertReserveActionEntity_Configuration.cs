using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class EquipmentExpertReserveActionEntity_Configuration
    : IEntityTypeConfiguration<EquipmentExpertReserveActionEntity>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<EquipmentExpertReserveActionEntity> builder)
    {
        builder
            .HasOne(u => u.EquipmentAction)
            .WithOne();

        builder.HasIndex(e => e.ReserveId);

        builder.HasIndex(eera => new
        {
            eera.ReserveId,
            eera.Id,
        });
    }
}