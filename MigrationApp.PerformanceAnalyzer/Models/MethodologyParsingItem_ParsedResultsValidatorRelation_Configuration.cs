using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class MethodologyParsingItem_ParsedResultsValidatorRelation_Configuration
    : IEntityTypeConfiguration<MethodologyParsingItem_ParsedResultsValidatorRelation>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<MethodologyParsingItem_ParsedResultsValidatorRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.MethodologyParsingItemId, c.ParsedResultsValidatorId });
    }
}