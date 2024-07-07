using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#pragma warning disable SA1649
namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class OfficeEntity_Configuration : IEntityTypeConfiguration<OfficeEntity>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<OfficeEntity> builder)
    {
        builder.HasAlternateKey(c => new { c.NameId, c.CityId });
    }
}