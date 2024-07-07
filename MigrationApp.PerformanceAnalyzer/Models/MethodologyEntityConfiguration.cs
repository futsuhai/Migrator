using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
public class MethodologyEntityConfiguration : IEntityTypeConfiguration<MethodologyEntity>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<MethodologyEntity> builder)
    {
        builder.HasIndex(m => m.TestCode).IsUnique();

        NpgsqlIndexBuilderExtensions.IncludeProperties(
            builder.HasIndex(m => m.Id),
            m => new object[] { m.TestCode });

        NpgsqlIndexBuilderExtensions.IncludeProperties(
            builder.HasIndex(m => m.Id),
            m => new object[]
            {
                m.IterParameterId, m.TestCode, m.ReportPath, m.Status, m.ResponsibleExpertId, m.CanHaveHealthCharts,
                m.CreatedAt, m.ModifiedAt, m.CreatedBy, m.ModifiedBy, m.StandartTestsScheme,
                m.CalibrationTestsScheme, m.AreHealthChartsPerTest, m.HasCharts, m.CanTesterUploadCommonFiles,
                m.CommonFilesExtensions, m.CommonFilesTitleAlias, m.TestingType, m.AssessmentAccuracy, m.Version,
                m.ParameterGroupType, m.FullNameId, m.ReportSubTitleId, m.ShortDescriptionId, m.SubTasksId,
                m.TestingReasonId, m.TestsFinishCriterionId, m.AreIterParameterFilesSeparated,
                m.AreResultParameterFilesSeparated, m.CustomResultTableEnabled, m.DefaultResultTableEnabled,
                m.ChartGroupingParameterId, m.MainTargetParameterId,
            });
    }
}