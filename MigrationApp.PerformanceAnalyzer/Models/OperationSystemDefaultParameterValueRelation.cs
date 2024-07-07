using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь операционнонй системы со значениями по умолчанию.
/// </summary>
[Table("OperationSystem_DefaultParameterValueRelation")]
public class OperationSystemDefaultParameterValueRelation : EntityBase
{
    /// <summary>
    /// Идентификатор операционной системы.
    /// </summary>
    [ForeignKey("OperationSystem")]
    public Guid OperationSystemId { get; set; }

    /// <summary>
    /// Операционная система.
    /// </summary>
    public virtual OperationSystemEntity OperationSystem { get; set; }

    /// <summary>
    /// Идентификатор значения параметра.
    /// </summary>
    [ForeignKey("ParameterValue")]
    public Guid ParameterValueId { get; set; }

    /// <summary>
    /// Значение параметра.
    /// </summary>
    public virtual ParameterValueEntity ParameterValue { get; set; }
}