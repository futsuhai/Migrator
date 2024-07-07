namespace MigrationApp.PerformanceAnalyzer.Models.Enums;

/// <summary>
/// Тип обработки файла результата.
/// </summary>
public enum ProcessingStrategyType
{
    /// <summary>
    /// По умолчанию.
    /// </summary>
    Default = 0,

    /// <summary>
    /// Кастомная.
    /// </summary>
    Custom,

    /// <summary>
    /// С описаниями.
    /// </summary>
    Declared,

    /// <summary>
    /// С описаниями для содержимого архива.
    /// </summary>
    InnerDeclared,
}