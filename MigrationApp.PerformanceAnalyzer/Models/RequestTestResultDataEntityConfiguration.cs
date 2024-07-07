using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
public class RequestTestResultDataEntityConfiguration : IEntityTypeConfiguration<RequestTestResultDataEntity>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<RequestTestResultDataEntity> builder)
    {
        NpgsqlIndexBuilderExtensions.IncludeProperties(
            builder.HasIndex(p => p.RequestTestId),
            p => new object[] { p.ResultParameterId });
    }
}