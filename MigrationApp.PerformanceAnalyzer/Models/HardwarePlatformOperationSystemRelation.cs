using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь аппаратной платформы с операционной системой.
/// </summary>
[Table("HardwarePlatform_OperationSystemRelation")]
public class HardwarePlatformOperationSystemRelation : EntityBase
{
    /// <summary>
    /// Аппаратная платформа.
    /// </summary>
    public virtual HardwarePlatformEntity HardwarePlatform { get; set; }

    /// <summary>
    /// Идентификатор платформы.
    /// </summary>
    [ForeignKey("HardwarePlatform")]
    public Guid HardwarePlatformId { get; set; }

    /// <summary>
    /// Операционная система.
    /// </summary>
    public virtual OperationSystemEntity OperationSystem { get; set; }

    /// <summary>
    /// Идентификатор ОС.
    /// </summary>
    [ForeignKey("OperationSystem")]
    public Guid OperationSystemId { get; set; }
}