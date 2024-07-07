using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Значение параметра заявки для сценария тестирования.
/// </summary>
[Table("MethodologyScenario_RequestParameterValueRelation")]
public class MethodologyScenario_RequestParameterValueRelation : EntityBase
{
    /// <summary>
    /// Сценарий тестирования для методики.
    /// </summary>
    public virtual MethodologyScenarioEntity MethodologyScenario { get; set; }

    /// <summary>
    /// Идентификатор сценария тестирования для методики.
    /// </summary>
    public Guid MethodologyScenarioId { get; set; }

    /// <summary>
    /// Значение параметра.
    /// </summary>
    public virtual ParameterValueEntity ParameterValue { get; set; }

    /// <summary>
    /// Значения параметра.
    /// </summary>
    [ForeignKey("ParameterValue")]
    public Guid ParameterValueId { get; set; }
}