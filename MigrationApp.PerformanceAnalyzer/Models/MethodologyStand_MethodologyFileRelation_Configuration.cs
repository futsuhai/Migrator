using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class MethodologyStand_MethodologyFileRelation_Configuration
    : IEntityTypeConfiguration<MethodologyStand_MethodologyFileRelation>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<MethodologyStand_MethodologyFileRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.MethodologyStandId, c.MethodologyFileId });
    }
}