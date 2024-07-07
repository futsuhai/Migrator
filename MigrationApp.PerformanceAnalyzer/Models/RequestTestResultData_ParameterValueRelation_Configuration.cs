using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
public class RequestTestResultData_ParameterValueRelation_Configuration : IEntityTypeConfiguration<RequestTestResultData_ParameterValueRelation>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<RequestTestResultData_ParameterValueRelation> builder)
    {
        builder.HasAlternateKey(c => new { c.RequestTestResultDataId, c.ParameterValueId });

        NpgsqlIndexBuilderExtensions.IncludeProperties(
            builder.HasIndex(rt => 
                new { rt.RequestTestResultDataId, rt.Id }), rt => 
                new object[]
                {
                    rt.CreatedAt,
                    rt.ModifiedAt,
                    rt.ModifiedBy,
                    rt.CreatedBy,
                    rt.ParameterValueId,
                });
    }
}