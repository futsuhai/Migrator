using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
public class UserFavoriteProductGroupRelation_Configuration : IEntityTypeConfiguration<UserFavoriteProductGroupRelation>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<UserFavoriteProductGroupRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.UserId, c.ProductGroupId });
    }
}