namespace MigrationApp.PerformanceAnalyzer.Models.Enums;

/// <summary>
/// Тип сборки.
/// </summary>
[Flags]
public enum BuildTypeFlag
{
    /// <summary>
    /// Пустое значение.
    /// </summary>
    None = 0,

    /// <summary>
    /// В архиве.
    /// </summary>
    Archived = 1,

    /// <summary>
    /// Собрана.
    /// </summary>
    Builded = 1 << 1,

    /// <summary>
    /// Релиз кандидат.
    /// </summary>
    ReleaseCandidate = 1 << 2,

    /// <summary>
    /// Релиз.
    /// </summary>
    Release = 1 << 3,

    /// <summary>
    /// На сертификации.
    /// </summary>
    SertProcess = 1 << 4,

    /// <summary>
    /// Сертифицирована.
    /// </summary>
    Sertified = 1 << 5,
}