using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь продукта с дистрибутивами.
/// </summary>
public class ProductOvaDistributionRelation : EntityBase
{
    /// <summary>
    /// Идентификатор продукта.
    /// </summary>
    [ForeignKey(nameof(Product))]
    public Guid ProductId { get; set; }

    /// <summary>
    /// Идентификатор дистрибутива.
    /// </summary>
    [ForeignKey(nameof(OvaDistribution))]
    public Guid OvaDistributionId { get; set; }

    /// <summary>
    /// Продукт.
    /// </summary>
    public virtual ProductEntity Product { get; set; }

    /// <summary>
    /// Дистрибутив.
    /// </summary>
    public virtual OvaDistributionEntity OvaDistribution { get; set; }
}