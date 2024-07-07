using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Entity аппаратного обеспечения.
/// </summary>
[Table("HardwarePlatform")]
public class HardwarePlatformEntity : EntityBase
{
    /// <summary>
    /// Название аппаратной платформы.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Описание.
    /// </summary>
    public virtual TranslationRelationEntity ShortDescription { get; set; }

    /// <summary>
    /// Объем жесткого диска в ГБ.
    /// </summary>
    public string? HardDriveSize { get; set; }

    /// <summary>
    /// Количество ядер процессора.
    /// </summary>
    public string? ProcessorCoresCount { get; set; }

    /// <summary>
    /// Объем оперативной памяти в МБ.
    /// </summary>
    public string? RamAmount { get; set; }

    /// <summary>
    /// Количество проводных интерфейсов.
    /// </summary>
    public string? WiredInterfacesCount { get; set; }

    /// <summary>
    /// Идентификатор перевода описания.
    /// </summary>
    [ForeignKey(nameof(ShortDescription))]
    public Guid ShortDescriptionId { get; set; }

    /// <summary>
    /// Отношения с инстансами АП.
    /// </summary>
    public virtual ICollection<EquipmentHardwarePlatformRelationEntity> EquipmentHardwarePlatformRelations { get; set; }

    /// <summary>
    /// Отношения с инстансами ОС.
    /// </summary>
    public virtual ICollection<HardwarePlatformOperationSystemRelation> OperationSystemHardwarePlatformRelations { get; set; }

    /// <summary>
    /// Связи АП и параметров.
    /// </summary>
    public virtual ICollection<HardwarePlatformParameterValueRelation> ParameterValueRelations { get; set; }

    /// <summary>
    /// Параметры АП по умолчанию.
    /// </summary>
    public virtual ICollection<HardwarePlatformDefaultParameterValueRelation> DefaultParameterValueRelations { get; set; }

    /// <summary>
    /// Файлы АП.
    /// </summary>
    public virtual ICollection<HardwarePlatformFileEntity> HardwarePlatformFiles { get; set; }
}