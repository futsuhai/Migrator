using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
public class TemplateTestParameterValueRelationEntity_Configuration : IEntityTypeConfiguration<TemplateTestParameterValueRelationEntity>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<TemplateTestParameterValueRelationEntity> builder)
    {
        builder.HasAlternateKey(c => new { c.TemplateTestId, c.ParameterValueId });
    }
}