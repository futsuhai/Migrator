using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь методики и оппаратной платформы.
/// </summary>
[Table("Methodology_HardwarePlatformRelation")]
public class MethodologyHardwarePlatformRelation : EntityBase
{
    /// <summary>
    /// Аппаратная платформа.
    /// </summary>
    public virtual HardwarePlatformEntity HardwarePlatform { get; set; }

    /// <summary>
    /// Идентификатор аппаратной платформы.
    /// </summary>
    [ForeignKey("HardwarePlatform")]
    public Guid HardwarePlatformId { get; set; }

    /// <summary>
    /// Методика тестирования.
    /// </summary>
    public virtual MethodologyEntity Methodology { get; set; }

    /// <summary>
    /// Идентификатор методики.
    /// </summary>
    [ForeignKey("Methodology")]
    public Guid MethodologyId { get; set; }
}