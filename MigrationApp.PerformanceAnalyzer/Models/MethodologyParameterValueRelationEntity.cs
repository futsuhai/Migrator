using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Набор дефолтных значений для методики.
/// </summary>
[Table("Methodology_ParameterValue")]
public class MethodologyParameterValueRelationEntity : EntityBase
{
    /// <summary>
    /// Связь параметра и методики.
    /// </summary>
    public virtual MethodologyParameterRelation MethodologyParameterRelation { get; set; }

    /// <summary>
    /// Идентификатор связи параметра и методики.
    /// </summary>
    [ForeignKey("MethodologyParameterRelation")]
    public Guid MethodologyParameterRelationId { get; set; }

    /// <summary>
    /// Значение параметра.
    /// </summary>
    public virtual ParameterValueEntity ParameterValue { get; set; }

    /// <summary>
    /// Идентификатор значения параметра.
    /// </summary>
    [ForeignKey("ParameterValue")]
    public Guid ParameterValueId { get; set; }
}