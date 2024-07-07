namespace MigrationApp.AnalyticsService.Models.Enums;

/// <summary>
/// Направление улучшения значения показателя.
/// </summary>
public enum ResultParameterImprovementDirection
{
    /// <summary>
    /// Должен расти.
    /// </summary>
    MinAndGreater,

    /// <summary>
    /// Должен уменьшаться.
    /// </summary>
    MaxAndLesser,

    /// <summary>
    /// Должен быть равным.
    /// </summary>
    Equal,
}