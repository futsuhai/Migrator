using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Схема стенда методики.
/// </summary>
public class MethodologyStandSchemeEntity : EntityBase
{
    /// <summary>
    /// Идентификатор методики.
    /// </summary>
    [ForeignKey(nameof(Methodology))]
    public Guid MethodologyId { get; set; }

    /// <summary>
    /// Идентификатор схемы стенда.
    /// </summary>
    [ForeignKey(nameof(StandScheme))]
    public Guid StandSchemeId { get; set; }

    /// <summary>
    /// Методика.
    /// </summary>
    public virtual MethodologyEntity Methodology { get; set; }

    /// <summary>
    /// Схема стенда.
    /// </summary>
    public virtual StandSchemeEntity StandScheme { get; set; }

    /// <summary>
    /// Триггеры схемы стенда.
    /// </summary>
    public virtual ICollection<MethodologyStandSchemeParameterValueRelation> Triggers { get; set; }
}