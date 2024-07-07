using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class MethodologyLanguageRelation_Configuration
    : IEntityTypeConfiguration<MethodologyLanguageRelation>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<MethodologyLanguageRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.MethodologyId, c.Language });
    }
}