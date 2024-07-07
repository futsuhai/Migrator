using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
public class RequestParameterValueRelation_Configuration : IEntityTypeConfiguration<RequestParameterValueRelation>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<RequestParameterValueRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.RequestId, c.ParameterValueId });

        builder.HasIndex(rpvr => new
        {
            rpvr.RequestId,
            rpvr.Id,
            rpvr.ParameterValueId,
        });
    }
}