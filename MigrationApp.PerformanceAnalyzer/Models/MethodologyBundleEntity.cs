using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Методология группы заявок.
/// </summary>
[Table("MethodologyBundle")]
public class MethodologyBundleEntity : EntityBase
{
    /// <summary>
    /// Полное название.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Описание.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Путь до отчета.
    /// </summary>
    public string? ReportPath { get; set; }

    /// <summary>
    /// Элементы бандла.
    /// </summary>
    public virtual ICollection<MethodologyBundleItemEntity> MethodologyBundleItems { get; set; }
}