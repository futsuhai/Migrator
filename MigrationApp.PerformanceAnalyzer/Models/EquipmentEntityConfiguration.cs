using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
public class EquipmentEntityConfiguration : IEntityTypeConfiguration<EquipmentEntity>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<EquipmentEntity> builder)
    {
        NpgsqlIndexBuilderExtensions.IncludeProperties(
            builder.HasIndex(e => e.Id),
            e => new object[] { e.Name });
    }
}