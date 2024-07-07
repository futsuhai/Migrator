using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь оборудования и АП.
/// </summary>
[Table("Equipment_HardwarePlatformRelation")]
public class EquipmentHardwarePlatformRelationEntity : EntityBase
{
    /// <summary>
    /// Оборудование.
    /// </summary>
    public virtual EquipmentEntity Equipment { get; set; }

    /// <summary>
    /// Идентификатор оборудования.
    /// </summary>
    [ForeignKey("Equipment")]
    public Guid EquipmentId { get; set; }

    /// <summary>
    /// Аппаратная платформа.
    /// </summary>
    public virtual HardwarePlatformEntity HardwarePlatform { get; set; }

    /// <summary>
    /// Идентификатор аппаратной платформы.
    /// </summary>
    [ForeignKey("HardwarePlatform")]
    public Guid HardwarePlatformId { get; set; }
}