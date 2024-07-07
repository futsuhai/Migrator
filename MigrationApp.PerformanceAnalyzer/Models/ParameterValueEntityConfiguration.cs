using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class ParameterValueEntityConfiguration : IEntityTypeConfiguration<ParameterValueEntity>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<ParameterValueEntity> builder)
    {
        builder.HasIndex(c => c.ParameterId);

        builder.HasIndex(c => new
        {
            c.ParameterId,
            c.Id,
        });

        NpgsqlIndexBuilderExtensions.IncludeProperties(
            builder.HasIndex(c => new { c.Id, c.ParameterId }),
            pv => new object[] { pv.Value, pv.OrderIndex, pv.Visibility });


        NpgsqlIndexBuilderExtensions.IncludeProperties(
            builder.HasIndex(c => new { c.ParameterId, c.Id }),
            pv => new object[] { pv.Value, pv.OrderIndex, pv.Visibility });


        NpgsqlIndexBuilderExtensions.IncludeProperties(
            builder.HasIndex(c => new { c.ParameterId, c.Id }),
            pv => new object[] { pv.Value, pv.OrderIndex, pv.Visibility, pv.CreatedAt, pv.ModifiedBy });
    }
}