using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class OperationSystemDefaultParameterValueRelation_Configuariton
    : IEntityTypeConfiguration<OperationSystemDefaultParameterValueRelation>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<OperationSystemDefaultParameterValueRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.OperationSystemId, c.ParameterValueId });
    }
}