using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь версии продукта и значения параметра.
/// </summary>
[Table("ProductVersion_ParameterValueRelation")]
public class ProductVersionParameterValueRelation : EntityBase
{
    /// <summary>
    /// Значения параметра.
    /// </summary>
    public virtual ParameterValueEntity ParameterValue { get; set; }

    /// <summary>
    /// Идентификатор значения параметра.
    /// </summary>
    [ForeignKey("ParameterValue")]
    public Guid ParameterValueId { get; set; }

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