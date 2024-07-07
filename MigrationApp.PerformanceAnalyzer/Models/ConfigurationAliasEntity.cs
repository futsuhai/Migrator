using System.ComponentModel.DataAnnotations.Schema;
using MigrationApp.PerformanceAnalyzer.Models.Enums;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Псевдоним конфигурации.
/// </summary>
public class ConfigurationAliasEntity : EntityBase
{
    /// <summary>
    /// Псевдоним.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Тип псевдонима.
    /// </summary>
    public ConfigurationAliasType Type { get; set; }

    /// <summary>
    /// Идентификатор связи показателя с конфигурацией.
    /// </summary>
    [ForeignKey(nameof(Configuration_ResultParameterRelation))]
    public Guid ConfigurationResultParameterRelationId { get; set; }

    /// <summary>
    /// Связь показателя с конфигурацией.
    /// </summary>
    public virtual Configuration_ResultParameterRelation Configuration_ResultParameterRelation { get; set; }
}