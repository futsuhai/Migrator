using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
public class RequestChangesHistoryEntityConfiguration : IEntityTypeConfiguration<RequestChangesHistoryEntity>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<RequestChangesHistoryEntity> builder)
    {
        builder.HasIndex(rch => rch.RequestId);

        NpgsqlIndexBuilderExtensions.IncludeProperties(
            builder.HasIndex(rch => new { rch.RequestId, rch.NewStatus }),
            rch => new object[] { rch.ChangeDate });

        NpgsqlIndexBuilderExtensions.IncludeProperties(
            builder.HasIndex(rch => new { rch.RequestId, rch.ChangeDate }),
            rch => new object[]
            {
                rch.Id,
                rch.OldStatus,
                rch.CreatedAt,
                rch.ModifiedAt,
                rch.CreatedBy,
                rch.ModifiedBy,
                rch.Conclusion,
            });
    }
}