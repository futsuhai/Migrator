using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc/>
internal class DashboardPresetProductRelation_Configuration
    : IEntityTypeConfiguration<DashboardPresetProductRelation>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<DashboardPresetProductRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.PresetId, c.ProductId });
    }
}