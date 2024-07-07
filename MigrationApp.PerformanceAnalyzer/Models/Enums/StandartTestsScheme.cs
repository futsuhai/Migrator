namespace MigrationApp.PerformanceAnalyzer.Models.Enums;

/// <summary>
/// Требования к стандартным тестам.
/// </summary>
public enum StandartTestsScheme
{
    /// <summary>
    /// Поведение не определено.
    /// </summary>
    Undefined = 0,

    /// <summary>
    /// Один стандартный тест.
    /// </summary>
    OneStandart = 1,

    /// <summary>
    /// Несколько стандартных тестов.
    /// </summary>
    ManyStandart = 2,
}