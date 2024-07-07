using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class MethodologyParameterRelation_Configuration
    : IEntityTypeConfiguration<MethodologyParameterRelation>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<MethodologyParameterRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.MethodologyId, c.ParameterId });

        builder.HasIndex(e => e.ParameterId);

        builder.HasIndex(mpr => new
        {
            mpr.ParameterId,
            mpr.MethodologyId,
        });
    }
}