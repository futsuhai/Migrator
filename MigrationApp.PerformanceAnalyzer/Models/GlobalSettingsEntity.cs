using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Сущность из таблицы настроек.
/// </summary>
[Table("GlobalSettings")]
public class GlobalSettingsEntity : EntityBase
{
    /// <summary>
    /// Имя параметра.
    /// </summary>
    public string CodeName { get; set; }

    /// <summary>
    /// Значение параметра.
    /// </summary>
    public string Value { get; set; }

    /// <summary>
    /// Описание параметра.
    /// </summary>
    public string Description { get; set; }
}