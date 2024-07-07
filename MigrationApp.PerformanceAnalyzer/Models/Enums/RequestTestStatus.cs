namespace MigrationApp.PerformanceAnalyzer.Models.Enums;

/// <summary>
/// Статусы теста.
/// </summary>
public enum RequestTestStatus
{
    /// <summary>
    /// Создан.
    /// </summary>
    Proposed = 0,

    /// <summary>
    /// Создан.
    /// </summary>
    Planned = 1,

    /// <summary>
    /// Создан.
    /// </summary>
    Approved = 2,

    /// <summary>
    /// Идет тестирование.
    /// </summary>
    Active = 3,

    /// <summary>
    /// Выполнен.
    /// </summary>
    Completed = 4,

    /// <summary>
    /// Не выполнен.
    /// </summary>
    Failed = 5,

    /// <summary>
    /// Отменен.
    /// </summary>
    Canceled = 6,
}