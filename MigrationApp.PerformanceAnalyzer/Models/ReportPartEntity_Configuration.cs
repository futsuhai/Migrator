using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class ReportPartEntity_Configuration
    : IEntityTypeConfiguration<ReportPartEntity>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<ReportPartEntity> builder)
    {
        builder.HasAlternateKey(c => new { c.Name });
        builder.Property(c => c.Name).HasMaxLength(255);
        builder.Property(c => c.FrxPath).HasMaxLength(255).IsRequired();
    }
}