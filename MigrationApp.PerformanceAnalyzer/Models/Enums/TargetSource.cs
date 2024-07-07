namespace MigrationApp.PerformanceAnalyzer.Models.Enums;

/// <summary>
/// Источник цели.
/// </summary>
public enum TargetSource
{
    /// <summary>
    /// Импортирована из файла.
    /// </summary>
    File = 0,

    /// <summary>
    /// Установлена вручную.
    /// </summary>
    Manual = 1,

    /// <summary>
    /// Скопирована с другого продукта.
    /// </summary>
    Copied = 2,
}