using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь версии продукта и пакета методик тестирования.
/// </summary>
[Table("ProductVersion_MethodologyBundleRelation")]
public class ProductVersionMethodologyBundleRelation : EntityBase
{
    /// <summary>
    /// Методика тестирования.
    /// </summary>
    public virtual MethodologyBundleEntity MethodologyBundle { get; set; }

    /// <summary>
    /// Методика тестирования.
    /// </summary>
    [ForeignKey("MethodologyBundle")]
    public Guid MethodologyBundleId { get; set; }

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