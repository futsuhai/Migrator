using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class MethodologyParserRelation_Configuration
    : IEntityTypeConfiguration<MethodologyParserRelation>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<MethodologyParserRelation> builder)
    {
        builder
            .HasAlternateKey(c => new { c.MethodologyId, c.ParserId });
    }
}