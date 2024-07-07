using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Настройки видимости параметра методики от продукта.
/// </summary>
[Table(nameof(MethodologyParameterProductVisibilityRelation))]
public class MethodologyParameterProductVisibilityRelation : EntityBase
{
    /// <summary>
    /// Связь методики с параметром.
    /// </summary>
    public virtual MethodologyParameterRelation MethodologyParameterRelation { get; set; }

    /// <summary>
    /// Продукт.
    /// </summary>
    public virtual ProductEntity Product { get; set; }

    /// <summary>
    /// Идентификатор.
    /// </summary>
    [ForeignKey(nameof(MethodologyParameterRelation))]
    public Guid MethodologyParameterRelationId { get; set; }

    /// <summary>
    /// Идентификатор.
    /// </summary>
    [ForeignKey(nameof(Product))]
    public Guid ProductId { get; set; }
}