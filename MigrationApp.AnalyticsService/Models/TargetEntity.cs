using MigrationApp.AnalyticsService.Models.Enums;
using MigrationApp.AnalyticsService.Models.Interfaces;
using MigrationApp.Common;
using MigrationApp.Common.Models;

namespace MigrationApp.AnalyticsService.Models;

/// <summary>
/// Цель.
/// </summary>
public class TargetEntity : IEntity, IAnalyticsTargetModel
{
    /// <inheritdoc cref="IAnalyticsTargetModel.Id"/>
    public Guid Id { get; set; }

    /// <summary>
    /// Меньшая граница диапазона цели.
    /// </summary>
    public double? MinValue { get; set; }

    /// <summary>
    /// Большая граница диапазона цели.
    /// </summary>
    public double? MaxValue { get; set; }

    /// <summary>
    /// Большая граница диапазона цели.
    /// </summary>
    public double? MaxTarget { get; set; }

    /// <summary>
    /// Меньшая граница диапазона цели.
    /// </summary>
    public double? MinTarget { get; set; }

    /// <summary>
    /// Большая граница диапазона отклонения.
    /// </summary>
    public double? MaxDeviation { get; set; }

    /// <summary>
    /// Меньшая граница диапазона отклонения.
    /// </summary>
    public double? MinDeviation { get; set; }

    /// <summary>
    /// Направление улучшения показателя.
    /// </summary>
    public ResultParameterImprovementDirection ResultParameterImprovementDirection { get; set; }

    /// <summary>
    /// Результаты.
    /// </summary>
    public ICollection<ResultEntity> Results { get; set; }
}