using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
public class StandSchemeTestObjectRelation_Configuration : IEntityTypeConfiguration<StandSchemeTestObjectRelation>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<StandSchemeTestObjectRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.StandSchemeId, c.TestObjectId });
    }
}