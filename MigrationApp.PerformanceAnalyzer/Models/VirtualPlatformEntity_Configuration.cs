using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class VirtualPlatformEntity_Configuration : IEntityTypeConfiguration<VirtualPlatformEntity>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<VirtualPlatformEntity> builder)
    {
        builder.HasAlternateKey(c => c.Name);
    }
}