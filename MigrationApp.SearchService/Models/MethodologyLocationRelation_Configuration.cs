using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.SearchService.Models;

/// <inheritdoc />
internal class MethodologyLocationRelation_Configuration : IEntityTypeConfiguration<MethodologyLocationRelation>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<MethodologyLocationRelation> builder)
    {
        builder.HasKey(e => new { e.LocationId, e.MethodologyId });
    }
}