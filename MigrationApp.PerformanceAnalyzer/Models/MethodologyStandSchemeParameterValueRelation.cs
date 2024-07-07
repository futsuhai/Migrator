using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Триггер схемы стенда методики.
/// </summary>
public class MethodologyStandSchemeParameterValueRelation : EntityBase
{
    /// <summary>
    /// Идентификатор схемы стенда.
    /// </summary>
    [ForeignKey(nameof(MethodologyStandScheme))]
    public Guid MethodologyStandSchemeId { get; set; }

    /// <summary>
    /// Идентификатор значения параметра.
    /// </summary>
    [ForeignKey(nameof(ParameterValue))]
    public Guid ParameterValueId { get; set; }

    /// <summary>
    /// Схема стенда методики.
    /// </summary>
    public virtual MethodologyStandSchemeEntity MethodologyStandScheme { get; set; }

    /// <summary>
    /// Значение параметра.
    /// </summary>
    public virtual ParameterValueEntity ParameterValue { get; set; }
}