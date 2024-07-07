using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class MethodologyUserSettingsEntity_Configuration : IEntityTypeConfiguration<MethodologyUserSettingsEntity>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<MethodologyUserSettingsEntity> builder)
    {
        builder.HasAlternateKey(c => new { c.UserId, c.MethodologyId });

        builder.HasIndex(mus => new
        {
            mus.IsCompetent,
            mus.UserId,
            mus.Id,
            mus.MethodologyId,
        });
    }
}