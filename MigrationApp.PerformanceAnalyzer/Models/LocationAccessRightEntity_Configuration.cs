using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class LocationAccessRightEntity_Configuration : IEntityTypeConfiguration<LocationAccessRightEntity>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<LocationAccessRightEntity> builder)
    {
        builder.HasAlternateKey(c => new { c.LocationId, c.UserId });
    }
}