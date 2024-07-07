using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Триггер, описывающий когда должна применяться схема.
/// </summary>
[Table("MethodologyStandTrigger")]
public class MethodologyStandTrigger : EntityBase
{
    /// <summary>
    /// Схема стенда, к которой привязан триггер.
    /// </summary>
    public virtual MethodologyStandEntity MethodologyStand { get; set; }

    /// <summary>
    /// Идентификатор схемы стенда.
    /// </summary>
    [ForeignKey("MethodologyStand")]
    public Guid MethodologyStandId { get; set; }

    /// <summary>
    /// Значения, приводящие к выбору схемы стенда.
    /// </summary>
    public virtual ICollection<MethodologyStandTrigger_ParameterValue> TriggeringValues { get; set; }
}