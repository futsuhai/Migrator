using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Целевой показатель версии продукта.
/// </summary>
[Table("ProductVersionTarget")]
public class ProductVersionTargetEntity : EntityBase
{
    /// <summary>
    /// Минимальное значение.
    /// </summary>
    [Column(TypeName = "decimal(18,4)")]
    public decimal MinValue { get; set; }

    /// <summary>
    /// Максимальное значение.
    /// </summary>
    [Column(TypeName = "decimal(18,4)")]
    public decimal MaxValue { get; set; }

    /// <summary>
    /// Скорость интерфейса (для Generic).
    /// </summary>
    public string InterfaceSpeed { get; set; }

    /// <summary>
    /// Идентификатор версии продукта.
    /// </summary>
    [ForeignKey("ProductVersion")]
    public Guid ProductVersionId { get; set; }

    /// <summary>
    /// Версия продукта.
    /// </summary>
    public virtual ProductVersionEntity ProductVersion { get; set; }

    /// <summary>
    /// Идентификатор методики.
    /// </summary>
    [ForeignKey("Methodology")]
    public Guid MethodologyId { get; set; }

    /// <summary>
    /// Методика.
    /// </summary>
    public virtual MethodologyEntity Methodology { get; set; }

    /// <summary>
    /// Идентификатор целевого показателя.
    /// </summary>
    [ForeignKey("Target")]
    public Guid TargetId { get; set; }

    /// <summary>
    /// Целевой показатель.
    /// </summary>
    public virtual TargetEntity Target { get; set; }

    /// <summary>
    /// Feature Set.
    /// </summary>
    public string FeatureSet { get; set; }
}