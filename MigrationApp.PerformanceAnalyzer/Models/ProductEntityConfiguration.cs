using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
public class ProductEntityConfiguration : IEntityTypeConfiguration<ProductEntity>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<ProductEntity> builder)
    {
        builder.HasIndex(e => e.ProductGroupId);

        NpgsqlIndexBuilderExtensions.IncludeProperties(
            builder.HasIndex(p => p.Name),
            p => new object[] { p.Id });

        NpgsqlIndexBuilderExtensions.IncludeProperties(
            builder.HasIndex(p => new { p.ProductGroupId, p.Id }),
            p => new object[]
            {
                p.Name, p.ShortDescription, p.ProductCategory, p.FeatureSetsEnabled, p.ForcedTestsScheme,
                p.CreatedAt, p.ModifiedAt, p.CreatedBy, p.ModifiedBy, p.OvaId, p.IsDraft,
                p.CanCreateRequestFromFile, p.TargetFileSupport,
            });
    }
}