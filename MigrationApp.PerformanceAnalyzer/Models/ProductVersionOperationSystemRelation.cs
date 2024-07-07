using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь версии продукта и операционной системы.
/// </summary>
[Table("ProductVersion_OperationSystemRelation")]
public class ProductVersionOperationSystemRelation : EntityBase
{
    /// <summary>
    /// Операционная система.
    /// </summary>
    public virtual OperationSystemEntity OperationSystem { get; set; }

    /// <summary>
    /// Идентификатор операционной системы.
    /// </summary>
    [ForeignKey("OperationSystem")]
    public Guid OperationSystemId { get; set; }

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