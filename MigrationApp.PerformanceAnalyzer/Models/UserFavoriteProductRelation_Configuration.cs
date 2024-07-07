using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
public class UserFavoriteProductRelation_Configuration : IEntityTypeConfiguration<UserFavoriteProductRelation>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<UserFavoriteProductRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.UserId, c.ProductId });
    }
}