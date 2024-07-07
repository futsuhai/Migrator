using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Триггер видимости параметра методики.
/// </summary>
[Table("Methodology_ParameterRelationTrigger")]
public class MethodologyParameterTriggerEntity : EntityBase
{
    /// <summary>
    /// Связь методики и параметра.
    /// </summary>
    public virtual MethodologyParameterRelation MethodologyParameterRelation { get; set; }

    /// <summary>
    /// Идентификатор связи методики и параметра.
    /// </summary>
    [ForeignKey("MethodologyParameterRelation")]
    public Guid MethodologyParameterRelationId { get; set; }

    /// <summary>
    /// Значение параметра заявки для срабатывания триггера.
    /// </summary>
    public virtual ParameterValueEntity ParameterValue { get; set; }

    /// <summary>
    /// Идентификатор значения параметра заявки для срабатывания триггера.
    /// </summary>
    [ForeignKey("ParameterValue")]
    public Guid ParameterValueId { get; set; }
}