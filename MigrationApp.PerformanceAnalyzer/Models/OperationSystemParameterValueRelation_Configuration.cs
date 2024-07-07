using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class OperationSystemParameterValueRelation_Configuration
    : IEntityTypeConfiguration<OperationSystemParameterValueRelation>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<OperationSystemParameterValueRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.OperationSystemId, c.ParameterValueId });
    }
}