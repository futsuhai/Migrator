using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
public class TestEnvironmentObjectTestEnvironmentRelation_Configuration : IEntityTypeConfiguration<TestEnvironmentObjectTestEnvironmentRelation>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<TestEnvironmentObjectTestEnvironmentRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.TestEnvironmentId, c.ObjectTestEnvironmentId });
    }
}