using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class DecommissionedEquipmentEntity_Configuration : IEntityTypeConfiguration<DecommissionedEquipmentEntity>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<DecommissionedEquipmentEntity> builder)
    {
        builder
            .HasOne(u => u.Equipment)
            .WithOne();
    }
}