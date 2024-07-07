using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class LocationEntity_Configuration : IEntityTypeConfiguration<LocationEntity>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<LocationEntity> builder)
    {
        builder.HasAlternateKey(c => new { c.NameId, c.OfficeId });
    }
}