using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class DashboardPresetEntity_Configuration : IEntityTypeConfiguration<DashboardPresetEntity>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<DashboardPresetEntity> builder)
    {
        builder
            .HasAlternateKey(x => new { x.Name, x.UserId });
    }
}