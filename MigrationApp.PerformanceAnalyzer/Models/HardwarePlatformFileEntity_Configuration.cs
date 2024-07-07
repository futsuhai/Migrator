using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class HardwarePlatformFileEntity_Configuration : IEntityTypeConfiguration<HardwarePlatformFileEntity>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<HardwarePlatformFileEntity> builder)
    {
        builder.HasAlternateKey(c => new { c.HardwarePlatformId, c.StorageFileId });
    }
}