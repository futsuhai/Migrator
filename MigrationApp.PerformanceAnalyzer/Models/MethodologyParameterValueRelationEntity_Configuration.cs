using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class MethodologyParameterValueRelationEntity_Configuration
    : IEntityTypeConfiguration<MethodologyParameterValueRelationEntity>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<MethodologyParameterValueRelationEntity> builder)
    {
        builder.HasAlternateKey(c => new { c.MethodologyParameterRelationId, c.ParameterValueId });
    }
}