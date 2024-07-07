using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
public class ProductVersionEntityConfiguration : IEntityTypeConfiguration<ProductVersionEntity>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<ProductVersionEntity> builder)
    {
        builder.HasIndex(e => e.ProductId);

        builder.HasIndex(pv => new
        {
            pv.Id,
            pv.ProductId,
        });

        NpgsqlIndexBuilderExtensions.IncludeProperties(
            builder.HasIndex(pv => new { pv.Id, pv.ProductManagerId }),
            pv => new object[]
            {
                pv.ProductId,
                pv.Name,
                pv.ProjectId,
                pv.CreatedAt,
                pv.ModifiedAt,
                pv.CreatedBy,
                pv.ModifiedBy,
                pv.IsDraft,
            });

        NpgsqlIndexBuilderExtensions.IncludeProperties(
            builder.HasIndex(pv => new { pv.ProductId, pv.ProductManagerId, pv.Id, pv.ProjectId }),
            pv => new object[]
            {
                pv.Name,
                pv.CreatedAt,
                pv.ModifiedAt,
                pv.CreatedBy,
                pv.ModifiedBy,
                pv.IsDraft,
            });

        NpgsqlIndexBuilderExtensions.IncludeProperties(
            builder.HasIndex(pv => new { pv.ProductId, pv.Id }),
            pv => new object[]
            {
                pv.Name,
                pv.ProductManagerId,
                pv.ProjectId,
                pv.CreatedAt,
                pv.ModifiedAt,
                pv.CreatedBy,
                pv.ModifiedBy,
                pv.IsDraft,
            });

        NpgsqlIndexBuilderExtensions.IncludeProperties(
            builder.HasIndex(pv => new { pv.Id, pv.ProjectId }),
            pv => new object[]
            {
                pv.ProductId,
                pv.Name,
                pv.ProductManagerId,
                pv.CreatedAt,
                pv.ModifiedAt,
                pv.CreatedBy,
                pv.ModifiedBy,
                pv.IsDraft,
            });
    }
}