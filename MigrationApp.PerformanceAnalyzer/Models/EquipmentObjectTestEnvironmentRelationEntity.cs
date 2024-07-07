using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь оборудования и ОТО.
/// </summary>
[Table("Equipment_ObjectTestEnvironmentRelation")]
public class EquipmentObjectTestEnvironmentRelationEntity : EntityBase
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
    /// ОТО.
    /// </summary>
    public virtual ObjectTestEnvironmentEntity ObjectTestEnvironment { get; set; }

    /// <summary>
    /// Идентификатор ОТО.
    /// </summary>
    [ForeignKey("ObjectTestEnvironment")]
    public Guid ObjectTestEnvironmentId { get; set; }
}