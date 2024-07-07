using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.AnalyticsService.Models;

/// <inheritdoc />
internal class Result_ParameterValueRelationEntity_Configuration : IEntityTypeConfiguration<Result_ParameterValueRelationEntity>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<Result_ParameterValueRelationEntity> builder)
    {
        builder
            .HasIndex(e => new { e.ResultId, e.ParameterValueId })
            .IsUnique();
    }
}