using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
public class UserFavoriteBuildRelation_Configuration : IEntityTypeConfiguration<UserFavoriteBuildRelation>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<UserFavoriteBuildRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.UserId, c.BuildId });
    }
}