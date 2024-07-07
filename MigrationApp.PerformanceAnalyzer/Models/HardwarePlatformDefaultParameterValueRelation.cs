using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь аппаратной платформы со значениями по умолчанию.
/// </summary>
[Table("HardwarePlatform_DefaultParameterValueRelation")]
public class HardwarePlatformDefaultParameterValueRelation : EntityBase
{
    /// <summary>
    /// Идентификатор аппаратной платформы.
    /// </summary>
    [ForeignKey("HardwarePlatform")]
    public Guid HardwarePlatformId { get; set; }

    /// <summary>
    /// Аппаратная платформа.
    /// </summary>
    public virtual HardwarePlatformEntity HardwarePlatform { get; set; }

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