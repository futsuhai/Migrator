using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class CityEntity_Configuration : IEntityTypeConfiguration<CityEntity>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<CityEntity> builder)
    {
        builder.HasAlternateKey(c => new { c.NameId });
    }
}