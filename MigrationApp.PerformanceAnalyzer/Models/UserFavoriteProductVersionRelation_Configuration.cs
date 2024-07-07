using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
public class UserFavoriteProductVersionRelation_Configuration : IEntityTypeConfiguration<UserFavoriteProductVersionRelation>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<UserFavoriteProductVersionRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.UserId, c.ProductVersionId });
    }
}