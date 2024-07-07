using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class TargetRowEntity_Configuration
    : IEntityTypeConfiguration<TargetRowEntity>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<TargetRowEntity> builder)
    {
        builder.HasIndex(c => new
            { c.ProductVersionName, c.ProductGroupId, c.Name, }).IsUnique();
    }
}