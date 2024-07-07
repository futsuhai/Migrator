using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class MethodologyFileParameterValueRelationEntity_Configuration
    : IEntityTypeConfiguration<MethodologyFileParameterValueRelationEntity>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<MethodologyFileParameterValueRelationEntity> builder)
    {
        builder.HasAlternateKey(c => new { c.MethodologyFileId, c.ParameterValueId });
    }
}