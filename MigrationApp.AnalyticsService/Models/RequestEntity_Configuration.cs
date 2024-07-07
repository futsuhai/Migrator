using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.AnalyticsService.Models;

/// <inheritdoc />
internal class RequestEntity_Configuration : IEntityTypeConfiguration<RequestEntity>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<RequestEntity> builder)
    {
        builder.HasIndex(e => e.Number).IsUnique();
        builder.HasIndex(e => new { e.ProductGroupId, e.ProductVersion });
    }
}