using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
public class RequestReviewEntityConfiguration : IEntityTypeConfiguration<RequestReviewEntity>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<RequestReviewEntity> builder)
    {
        builder.HasIndex(rr => rr.RequestId);

        NpgsqlIndexBuilderExtensions.IncludeProperties(
            builder.HasIndex(rr => new { rr.RequestId, rr.CreatedAt }),
            rr => new object[] { rr.ReviewStatus });

        NpgsqlIndexBuilderExtensions.IncludeProperties(
            builder.HasIndex(rr => rr.RequestId),
            rr => new object[]
            {
                rr.Id,
                rr.UserId,
                rr.Comment,
                rr.CreatedAt,
                rr.ModifiedAt,
                rr.CreatedBy,
                rr.ModifiedBy,
                rr.IsExpertComment,
                rr.ReviewStatus,
            });
    }
}