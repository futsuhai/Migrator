using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.AnalyticsService.Models;

/// <inheritdoc />
internal class ResultEntity_Configuration : IEntityTypeConfiguration<ResultEntity>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<ResultEntity> builder)
    {
        builder.HasIndex(e => e.RequestId);
        builder.HasIndex(e => e.ResultParameterId);
    }
}