namespace MigrationApp.PerformanceAnalyzer.Models.Enums;

/// <summary>
/// Контекст элемента парсинга.
/// </summary>
public enum ParsingItemBindingContext
{
    /// <summary>
    /// Любой тест.
    /// </summary>
    Any = 0,

    /// <summary>
    /// Стандартный тест.
    /// </summary>
    Standard,

    /// <summary>
    /// Калибровочный тест.
    /// </summary>
    Calibration,
}