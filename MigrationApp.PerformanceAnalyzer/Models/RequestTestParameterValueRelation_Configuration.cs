using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
public class RequestTestParameterValueRelation_Configuration : IEntityTypeConfiguration<RequestTestParameterValueRelation>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<RequestTestParameterValueRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.RequestTestId, c.ParameterValueId });
    }
}