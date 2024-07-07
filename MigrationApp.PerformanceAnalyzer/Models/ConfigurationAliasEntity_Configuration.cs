using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class ConfigurationAliasEntity_Configuration : IEntityTypeConfiguration<ConfigurationAliasEntity>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<ConfigurationAliasEntity> builder)
    {
        builder
            .HasAlternateKey(x => new { x.Type, x.ConfigurationResultParameterRelationId });
    }
}