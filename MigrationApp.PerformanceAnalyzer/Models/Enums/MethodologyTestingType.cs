namespace MigrationApp.PerformanceAnalyzer.Models.Enums;

/// <summary>
/// Тип тестирования.
/// </summary>
public enum MethodologyTestingType
{
    /// <summary>
    /// Тестирование производительности.
    /// </summary>
    Performance = 0,

    /// <summary>
    /// Тестирование стабильности.
    /// </summary>
    Stability = 1,

    /// <summary>
    /// Тестирование устойчивости.
    /// </summary>
    Stress = 2,
}