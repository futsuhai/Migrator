using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь виртуального исполнения и значения параметра.
/// </summary>
public class VirtualPlatformParameterValueRelation : EntityBase
{
    /// <summary>
    /// Идентификатор виртуального исполнения.
    /// </summary>
    [ForeignKey(nameof(VirtualPlatform))]
    public Guid VirtualPlatformId { get; set; }

    /// <summary>
    /// Идентификатор значения параметра.
    /// </summary>
    [ForeignKey(nameof(ParameterValue))]
    public Guid ParameterValueId { get; set; }

    /// <summary>
    /// Виртуальное исполнение.
    /// </summary>
    public virtual VirtualPlatformEntity VirtualPlatform { get; set; }

    /// <summary>
    /// Значение параметра..
    /// </summary>
    public virtual ParameterValueEntity ParameterValue { get; set; }
}