using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь продукта с ключевыми для него параметрами в отчете по сборкам.
/// </summary>
public class ProductBuildReportParameterRelation : EntityBase
{
    /// <summary>
    /// Идентификатор продукта.
    /// </summary>
    [ForeignKey(nameof(Product))]
    public Guid ProductId { get; set; }

    /// <summary>
    /// Идентификатор параметра.
    /// </summary>
    [ForeignKey(nameof(Parameter))]
    public Guid ParameterId { get; set; }

    /// <summary>
    /// Продукт.
    /// </summary>
    public virtual ProductEntity Product { get; set; }

    /// <summary>
    /// Параметр.
    /// </summary>
    public virtual ParameterEntity Parameter { get; set; }
}