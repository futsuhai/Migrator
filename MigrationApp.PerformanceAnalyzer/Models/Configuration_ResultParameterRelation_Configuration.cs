using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class Configuration_ResultParameterRelation_Configuration
    : IEntityTypeConfiguration<Configuration_ResultParameterRelation>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<Configuration_ResultParameterRelation> builder)
    {
        //TODO вернуть после обновления справочников на проде. 
        //builder.HasAlternateKey(c => new
        //    { c.ConfigurationId, c.ResultParameterId, c.ProductGroupId, c.ProductVersionName });
    }
}