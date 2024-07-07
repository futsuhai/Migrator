using System.ComponentModel.DataAnnotations.Schema;
using MigrationApp.PerformanceAnalyzer.Models.Enums;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Единица оборудования.
/// </summary>
[Table("Equipment")]
public class EquipmentEntity : EntityBase
{
    /// <summary>
    /// В утиле ли.
    /// </summary>
    public bool IsDecomissioned { get; set; }

    /// <summary>
    /// Является временным.
    /// </summary>
    public bool IsTemporary { get; set; }

    /// <summary>
    /// Название оборудования.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Принадлежность.
    /// </summary>
    public EquipmentOwn Own { get; set; }

    /// <summary>
    /// Локация.
    /// </summary>
    [ForeignKey(nameof(Location))]
    public Guid LocationId { get; set; }

    /// <summary>
    /// Серийник.
    /// </summary>
    public string SerialNumber { get; set; }

    /// <summary>
    /// Связи к аппаратным платформам.
    /// </summary>
    public virtual ICollection<EquipmentHardwarePlatformRelationEntity> HardwarePlatforms { get; set; } =
        new List<EquipmentHardwarePlatformRelationEntity>();

    /// <summary>
    /// Связи к объектам тестового окружения.
    /// </summary>
    public virtual ICollection<EquipmentObjectTestEnvironmentRelationEntity> ObjectTestEnvironments { get; set; } =
        new List<EquipmentObjectTestEnvironmentRelationEntity>();

    /// <summary>
    /// Локация.
    /// </summary>
    public virtual LocationEntity Location { get; set; }
}