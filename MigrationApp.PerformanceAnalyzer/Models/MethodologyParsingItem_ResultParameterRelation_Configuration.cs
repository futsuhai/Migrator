using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class MethodologyParsingItem_ResultParameterRelation_Configuration
    : IEntityTypeConfiguration<MethodologyParsingItem_ResultParameterRelation>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<MethodologyParsingItem_ResultParameterRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.MethodologyParsingItemId, c.ResultParameterId });
    }
}