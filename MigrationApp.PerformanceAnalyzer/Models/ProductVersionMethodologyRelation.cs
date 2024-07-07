using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь версии продукта и методики тестирования.
/// </summary>
[Table("ProductVersion_MethodologyRelation")]
public class ProductVersionMethodologyRelation : EntityBase
{
    /// <summary>
    /// Методика тестирования.
    /// </summary>
    public virtual MethodologyEntity Methodology { get; set; }

    /// <summary>
    /// Методика тестирования.
    /// </summary>
    [ForeignKey("Methodology")]
    public Guid MethodologyId { get; set; }

    /// <summary>
    /// Версия продукта.
    /// </summary>
    public virtual ProductVersionEntity ProductVersion { get; set; }

    /// <summary>
    /// Идентификатор версии продукта.
    /// </summary>
    [ForeignKey("ProductVersion")]
    public Guid ProductVersionId { get; set; }
}