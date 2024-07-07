using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
public class RequestEntityConfiguration : IEntityTypeConfiguration<RequestEntity>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<RequestEntity> builder)
    {
        builder.HasIndex(r => r.TesterId);

        NpgsqlIndexBuilderExtensions.IncludeProperties(
            builder.HasIndex(r => r.Status),
            r => new object[] { r.MethodologyId, r.ProductVersionId, r.BuildId });

        builder.HasIndex(r => new
        {
            r.TesterId,
            r.MethodologyId,
        });

        builder.HasIndex(r => new
        {
            r.ShortId,
        });

        NpgsqlIndexBuilderExtensions.IncludeProperties(
            builder.HasIndex(r => new { r.Id, r.TesterId }),
            r => new object[] { r.Status, r.Color, r.Comment, r.ShortId });

        builder.HasIndex(r => new
        {
            r.TesterId,
            r.Id,
            r.ProductVersionId,
        });

        NpgsqlIndexBuilderExtensions.IncludeProperties(
            builder.HasIndex(r => r.Id),
            r => new object[] { r.TesterId, r.LocationId });
    }
}