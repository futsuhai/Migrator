using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class ConfigurationEntity_Configuration : IEntityTypeConfiguration<ConfigurationEntity>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<ConfigurationEntity> builder)
    {
        builder.Property(x => x.Order).HasDefaultValue(0);
    }
}