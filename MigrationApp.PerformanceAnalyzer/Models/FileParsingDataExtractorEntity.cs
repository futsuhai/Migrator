namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Извлекатель данных из файла.
/// </summary>
public class FileParsingDataExtractorEntity : EntityBase
{
    /// <summary>
    /// Название.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Описание.
    /// </summary>
    public string? Description { get; set; }
}