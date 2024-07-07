using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class VirtualPlatformParameterValueRelation_Configuration : IEntityTypeConfiguration<VirtualPlatformParameterValueRelation>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<VirtualPlatformParameterValueRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.VirtualPlatformId, c.ParameterValueId });
    }
}