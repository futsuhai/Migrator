namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Валидатор полученных из файла данных.
/// </summary>
public class ParsedResultsValidatorEntity : EntityBase
{
    /// <summary>
    /// Название.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Описание.
    /// </summary>
    public string Description { get; set; }
}