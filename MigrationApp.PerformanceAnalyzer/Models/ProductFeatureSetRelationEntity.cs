using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь методики и параметра.
/// </summary>
[Table("Product_FeatureSetRelation")]
public class ProductFeatureSetRelationEntity : EntityBase
{
    /// <summary>
    /// Feature Set.
    /// </summary>
    public virtual FeatureSetEntity FeatureSet { get; set; }

    /// <summary>
    /// Feature Set ID.
    /// </summary>
    [ForeignKey("FeatureSet")]
    public Guid FeatureSetId { get; set; }

    /// <summary>
    /// Продукт.
    /// </summary>
    public virtual ProductEntity Product { get; set; }

    /// <summary>
    /// Идентификатор продукта.
    /// </summary>
    [ForeignKey("Product")]
    public Guid ProductId { get; set; }
}