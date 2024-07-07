namespace MigrationApp.PerformanceAnalyzer.Models.Enums;

/// <summary>
/// Тип файла методики.
/// </summary>
public enum MethodologyFileType
{
    /// <summary>
    /// Файл описания.
    /// </summary>
    Description = 0,

    /// <summary>
    /// Скрипты тестирования.
    /// </summary>
    TestScripts = 1,

    /// <summary>
    /// Схема стенда.
    /// </summary>
    Scheme = 2,

    /// <summary>
    /// Пример отчета.
    /// </summary>
    ReportSample = 3,

    /// <summary>
    /// Шаблон отчета.
    /// </summary>
    ReportTemplate = 4,

    /// <summary>
    /// Видеофайл.
    /// </summary>
    VideoFile = 5,

    /// <summary>
    /// Другое.
    /// </summary>
    Other = 6,
}