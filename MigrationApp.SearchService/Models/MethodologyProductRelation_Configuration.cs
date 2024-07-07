using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.SearchService.Models;

/// <inheritdoc />
internal class MethodologyProductRelation_Configuration : IEntityTypeConfiguration<MethodologyProductRelation>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<MethodologyProductRelation> builder)
    {
        builder.HasKey(e => new { e.MethodologyId, e.ProductId });
    }
}