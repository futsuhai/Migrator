using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
public class ProductVersion_Build_ResultHashEntityConfiguration : IEntityTypeConfiguration<ProductVersion_Build_ResultHashEntity>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<ProductVersion_Build_ResultHashEntity> builder)
    {
        builder.HasIndex(e => e.ProductVersionId);
        builder.HasIndex(e => e.AssemblyNumber);
    }
}