using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Целевой показатель.
/// </summary>
[Table("Target")]
public class TargetEntity : EntityBase
{
    /// <summary>
    /// Название целевой показатель.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Единицы измерения.
    /// </summary>
    public string Units { get; set; }

    /// <summary>
    /// Описание или полное название.
    /// </summary>
    public string Description { get; set; }
}