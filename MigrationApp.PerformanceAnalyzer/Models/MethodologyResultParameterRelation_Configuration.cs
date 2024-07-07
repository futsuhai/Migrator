using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MigrationApp.PerformanceAnalyzer.Models.Enums;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class MethodologyResultParameterRelation_Configuration
    : IEntityTypeConfiguration<MethodologyResultParameterRelation>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<MethodologyResultParameterRelation> builder)
    {
        builder
            .Property(x => x.BindingContext)
            .HasDefaultValue(ResultParameterBindingContext.Test);

        builder.HasIndex(p => new
        {
            p.MethodologyId,
            p.ResultParameterId,
        }).IsUnique();
    }
}