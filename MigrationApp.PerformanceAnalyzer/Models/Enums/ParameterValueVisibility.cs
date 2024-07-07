namespace MigrationApp.PerformanceAnalyzer.Models.Enums;

/// <summary>
/// Состояние видимости значения параметра.
/// </summary>
public enum ParameterValueVisibility
{
    /// <summary>
    /// Всегда видим.
    /// </summary>
    Default = 0,

    /// <summary>
    /// Возможно скрытие другими значениями параметров.
    /// </summary>
    Shadowed = 1,

    /// <summary>
    /// Возможно создание триггеров видимости.
    /// </summary>
    Triggered = 2,
}