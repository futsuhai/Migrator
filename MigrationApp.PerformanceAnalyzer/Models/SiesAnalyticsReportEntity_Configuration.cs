using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class SiesAnalyticsReportEntity_Configuration : IEntityTypeConfiguration<SiesAnalyticsReportEntity>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<SiesAnalyticsReportEntity> builder)
    {
        builder
            .HasIndex(c => new { c.ProductVersionId, c.Build, c.SdkVersionId })
            .IsUnique();
    }
}