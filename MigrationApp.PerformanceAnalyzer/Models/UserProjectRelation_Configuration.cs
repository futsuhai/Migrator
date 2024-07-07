using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class UserProjectRelation_Configuration : IEntityTypeConfiguration<UserProjectRelation>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<UserProjectRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.UserId, c.ProjectId });
    }
}