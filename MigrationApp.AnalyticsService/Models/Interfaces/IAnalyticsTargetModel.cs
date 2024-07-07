using MigrationApp.AnalyticsService.Models.Enums;

namespace MigrationApp.AnalyticsService.Models.Interfaces;

/// <summary>
/// Данные цели для синхронизации.
/// </summary>
public interface IAnalyticsTargetModel
{
    /// <summary>
    /// Идентификатор цели.
    /// </summary>
    public Guid Id { get; }

    /// <summary>
    /// Меньшая граница диапазона цели.
    /// </summary>
    public double? MinValue { get; }

    /// <summary>
    /// Большая граница диапазона цели.
    /// </summary>
    public double? MaxValue { get; }

    /// <summary>
    /// Направление улучшения показателя.
    /// </summary>
    public ResultParameterImprovementDirection ResultParameterImprovementDirection { get; }
}