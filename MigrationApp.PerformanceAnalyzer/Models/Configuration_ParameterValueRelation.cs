using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь конфигурации и значения параметра.
/// </summary>
[Table("Configuration_ParameterValueRelation")]
public class Configuration_ParameterValueRelation : EntityBase
{
    /// <summary>
    /// Конфигурация.
    /// </summary>
    public virtual ConfigurationEntity Configuration { get; set; }

    /// <summary>
    /// Идентификатор конфигурации.
    /// </summary>
    [ForeignKey(nameof(Configuration))]
    public Guid ConfigurationId { get; set; }

    /// <summary>
    /// Параметр.
    /// </summary>
    public virtual ParameterValueEntity ParameterValue { get; set; }

    /// <summary>
    /// Идентификатор параметра.
    /// </summary>
    [ForeignKey(nameof(ParameterValue))]
    public Guid ParameterValueId { get; set; }
}