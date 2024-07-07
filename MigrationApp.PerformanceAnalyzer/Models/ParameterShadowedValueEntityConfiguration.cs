using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
public class ParameterShadowedValueEntityConfiguration : IEntityTypeConfiguration<ParameterShadowedValueEntity>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<ParameterShadowedValueEntity> builder)
    {
        builder.HasIndex(e => e.ShadowedParameterValueId);

        NpgsqlIndexBuilderExtensions.IncludeProperties(
            builder.HasIndex(psv => psv.ShadowedParameterValueId),
            psv => new object[] { psv.Id, psv.AffectingParameterValueId });
    }
}