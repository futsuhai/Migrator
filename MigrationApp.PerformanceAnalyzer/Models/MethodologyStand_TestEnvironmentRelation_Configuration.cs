using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class MethodologyStand_TestEnvironmentRelation_Configuration
    : IEntityTypeConfiguration<MethodologyStand_TestEnvironmentRelation>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<MethodologyStand_TestEnvironmentRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.MethodologyStandId, c.TestEnvironmentId });
    }
}