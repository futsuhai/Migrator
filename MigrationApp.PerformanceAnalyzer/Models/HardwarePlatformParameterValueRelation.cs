using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь аппаратной платформы со значением параметра.
/// </summary>
[Table("HardwarePlatform_ParameterValueRelation")]
public class HardwarePlatformParameterValueRelation : EntityBase
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
    /// Значение параметра.
    /// </summary>
    public virtual ParameterValueEntity ParameterValue { get; set; }

    /// <summary>
    /// Идентификатор значения параметра.
    /// </summary>
    [ForeignKey("ParameterValue")]
    public Guid ParameterValueId { get; set; }
}