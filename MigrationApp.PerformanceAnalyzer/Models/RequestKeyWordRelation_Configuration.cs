using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
public class RequestKeyWordRelation_Configuration : IEntityTypeConfiguration<RequestKeyWordRelation>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<RequestKeyWordRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.RequestId, c.KeyWordId });
    }
}