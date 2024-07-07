using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class TranslationEntity_Configuration : IEntityTypeConfiguration<TranslationEntity>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<TranslationEntity> builder)
    {
        builder.HasAlternateKey(c => new { c.TranslationId, c.Language });

        NpgsqlIndexBuilderExtensions.IncludeProperties(
            builder.HasIndex(t => t.Language),
            t => new object[]
            {
                t.Id,
                t.CreatedAt,
                t.ModifiedAt,
                t.ModifiedBy,
                t.CreatedBy,
                t.Text,
                t.TranslationId,
            });

        NpgsqlIndexBuilderExtensions.IncludeProperties(
            builder.HasIndex(t => t.Id),
            t => new object[]
            {
                t.CreatedAt,
                t.ModifiedAt,
                t.ModifiedBy,
                t.CreatedBy,
            });
    }
}