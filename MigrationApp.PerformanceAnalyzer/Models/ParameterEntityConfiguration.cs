using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
public class ParameterEntityConfiguration : IEntityTypeConfiguration<ParameterEntity>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<ParameterEntity> builder)
    {
        NpgsqlIndexBuilderExtensions.IncludeProperties(
            builder.HasIndex(p => p.Id),
            p => new object[]
            {
                p.ParameterGroup,
                p.Name,
                p.Note,
                p.ParameterCode,
                p.ValueValidationRule
            });
    }
}