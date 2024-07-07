namespace MigrationApp.PerformanceAnalyzer.Models.Enums;

/// <summary>
/// Тип файла, прикрепленного к заявке.
/// </summary>
public enum RequestFileType
{
    /// <summary>
    /// Не может быть 0.
    /// </summary>
    Error = 0,

    /// <summary>
    /// Файл показателей здоровья.
    /// </summary>
    Health = 1,

    /// <summary>
    /// Файл результатов.
    /// </summary>
    TestResult = 2,
}