using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class Methodology_ReportPartRelation_Configuration
    : IEntityTypeConfiguration<Methodology_ReportPartRelation>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<Methodology_ReportPartRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.MethodologyId, c.ReportPartId });
        builder.HasIndex(c => new { c.MethodologyId, c.OrderIndex }).IsUnique();
    }
}