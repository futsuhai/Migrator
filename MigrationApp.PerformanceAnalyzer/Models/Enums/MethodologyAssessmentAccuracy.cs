namespace MigrationApp.PerformanceAnalyzer.Models.Enums;

/// <summary>
/// Точность оценки.
/// </summary>
public enum MethodologyAssessmentAccuracy
{
    /// <summary>
    /// Экспресс-оценка.
    /// </summary>
    Express = 0,

    /// <summary>
    /// Средняя точность.
    /// </summary>
    Average = 1,

    /// <summary>
    /// Высокая точность.
    /// </summary>
    High = 2,
}