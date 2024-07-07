using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь пресета дашборда с продуктом.
/// </summary>
public class DashboardPresetProductRelation : EntityBase
{
    /// <summary>
    /// Пресет.
    /// </summary>
    public virtual DashboardPresetEntity Preset { get; set; }

    /// <summary>
    /// Продукт.
    /// </summary>
    public virtual ProductEntity Product { get; set; }

    /// <summary>
    /// Идентификатор пресета.
    /// </summary>
    [ForeignKey(nameof(Preset))]
    public Guid PresetId { get; set; }

    /// <summary>
    /// Идентификатор продукта.
    /// </summary>
    [ForeignKey(nameof(Product))]
    public Guid ProductId { get; set; }
}