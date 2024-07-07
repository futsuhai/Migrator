using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь между триггером стенда и значением параметра.
/// </summary>
[Table("MethodologyStandTrigger_ParameterValue")]
public class MethodologyStandTrigger_ParameterValue : EntityBase
{
    /// <summary>
    /// Значение в завяке при котором должен срабатывать триггер.
    /// </summary>
    public virtual ParameterValueEntity TriggeringValue { get; set; }

    /// <summary>
    /// Идентификатор триггерирующего значения.
    /// </summary>
    public Guid TriggeringValueId { get; set; }

    /// <summary>
    /// Триггер.
    /// </summary>
    public virtual MethodologyStandTrigger Trigger { get; set; }

    /// <summary>
    /// Идентификатор триггера.
    /// </summary>
    [ForeignKey("Trigger")]
    public Guid TriggerId { get; set; }
}