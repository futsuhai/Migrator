using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Конфигурация.
/// </summary>
[Table("Configuration")]
public class ConfigurationEntity : EntityBase
{
    /// <summary>
    /// Наименование конфигурации.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Порядковый номер столбца в таблице.
    /// </summary>
    public int Order { get; set; }

    /// <summary>
    /// Идентификатор связанной методики.
    /// </summary>
    [ForeignKey(nameof(Methodology))]
    public Guid MethodologyId { get; set; }

    /// <summary>
    /// Идентификатор ОС.
    /// </summary>
    [ForeignKey(nameof(OperationSystem))]
    public Guid? OperationSystemId { get; set; }

    /// <summary>
    /// Идентификатор АП.
    /// </summary>
    [ForeignKey(nameof(HardwarePlatform))]
    public Guid? HardwarePlatformId { get; set; }

    /// <summary>
    /// Идентификатор ВП.
    /// </summary>
    [ForeignKey(nameof(VirtualPlatform))]
    public Guid? VirtualPlatformId { get; set; }

    /// <summary>
    /// Методика.
    /// </summary>
    public virtual MethodologyEntity Methodology { get; set; }

    /// <summary>
    /// ОС.
    /// </summary>
    public virtual OperationSystemEntity OperationSystem { get; set; }

    /// <summary>
    /// АП.
    /// </summary>
    public virtual HardwarePlatformEntity HardwarePlatform { get; set; }

    /// <summary>
    /// ВП.
    /// </summary>
    public virtual VirtualPlatformEntity VirtualPlatform { get; set; }

    /// <summary>
    /// Связи значений параметров.
    /// </summary>
    public virtual ICollection<Configuration_ParameterValueRelation> ParameterValueRelations { get; set; }

    /// <summary>
    /// Связи показателей.
    /// </summary>
    public virtual ICollection<Configuration_ResultParameterRelation> ResultParameterRelations { get; set; }
}