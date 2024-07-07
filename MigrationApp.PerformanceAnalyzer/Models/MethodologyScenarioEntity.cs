using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Сценарий тестирования для методики.
/// </summary>
[Table("MethodologyScenario")]
public class MethodologyScenarioEntity : EntityBase
{
    /// <summary>
    /// Методика.
    /// </summary>
    public virtual MethodologyEntity Methodology { get; set; }

    /// <summary>
    /// Идентификатор методики.
    /// </summary>
    [ForeignKey("Methodology")]
    public Guid MethodologyId { get; set; }

    /// <summary>
    /// Имя сценария.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Параметры заявки.
    /// </summary>
    public virtual ICollection<MethodologyScenario_RequestParameterValueRelation> RequestParameterValues { get; set; }

    /// <summary>
    /// Тесты в сценарии.
    /// </summary>
    public virtual ICollection<TemplateTestEntity> TemplateTests { get; set; }
}