using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Отношение скрывающихся параметров.
/// </summary>
[Table("ParameterShadowedValue")]
public class ParameterShadowedValueEntity : EntityBase
{
    /// <summary>
    /// Скрываемое значение параметра.
    /// </summary>
    public virtual ParameterValueEntity ShadowedParameterValue { get; set; }

    /// <summary>
    /// Идентификатор скрываемого значения параметра.
    /// </summary>
    [ForeignKey("ShadowedParameterValue")]
    public Guid ShadowedParameterValueId { get; set; }

    /// <summary>
    /// Скрывающее значение параметра.
    /// </summary>
    public virtual ParameterValueEntity AffectingParameterValue { get; set; }

    /// <summary>
    /// Идентификатор скрывающего значения параметра.
    /// </summary>
    [ForeignKey("AffectingParameterValue")]
    public Guid AffectingParameterValueId { get; set; }
}