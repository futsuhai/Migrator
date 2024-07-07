namespace MigrationApp.PerformanceAnalyzer.Models.Enums;

/// <summary>
/// Тип тестирования.
/// </summary>
[Flags]
public enum MethodologyTestingTypeFlag
{
    /// <summary>
    /// Пустое значение.
    /// </summary>
    None = 0,

    /// <summary>
    /// Тестирование производительности.
    /// </summary>
    Performance = 1,

    /// <summary>
    /// Тестирование стабильности.
    /// </summary>
    Stability = 1 << 1,

    /// <summary>
    /// Тестирование устойчивости.
    /// </summary>
    Stress = 1 << 2,
}