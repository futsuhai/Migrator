using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
public class EquipmentActionEntityConfiguration : IEntityTypeConfiguration<EquipmentActionEntity>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<EquipmentActionEntity> builder)
    {
        builder.HasIndex(ea => new
        {
            ea.Id,
            ea.StartDate,
            ea.EndDate,
            ea.EquipmentId,
        });

        builder.HasIndex(ea => new
        {
            ea.EndDate,
            ea.StartDate,
            ea.EquipmentId,
            ea.UserId,
            ea.Id,
        });
    }
}