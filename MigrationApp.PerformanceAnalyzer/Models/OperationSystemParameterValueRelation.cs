using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь ОС и значения параметра.
/// </summary>
[Table("OperationSystem_ParameterValueRelation")]
public class OperationSystemParameterValueRelation : EntityBase
{
    /// <summary>
    /// Операционная система.
    /// </summary>
    public virtual OperationSystemEntity OperationSystem { get; set; }

    /// <summary>
    /// Идентификатор ОС.
    /// </summary>
    [ForeignKey("OperationSystem")]
    public Guid OperationSystemId { get; set; }

    /// <summary>
    /// Значения параметра.
    /// </summary>
    public virtual ParameterValueEntity ParameterValue { get; set; }

    /// <summary>
    /// Идентификатор значения параметра.
    /// </summary>
    [ForeignKey("ParameterValue")]
    public Guid ParameterValueId { get; set; }
}