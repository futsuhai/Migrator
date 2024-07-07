using System.ComponentModel.DataAnnotations.Schema;
using MigrationApp.PerformanceAnalyzer.Models.Enums;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Шаблонный тест для методики.
/// </summary>
[Table("TemplateTest")]
public class TemplateTestEntity : EntityBase
{
    /// <summary>
    /// Сценарий тестирования.
    /// </summary>
    public virtual MethodologyScenarioEntity MethodologyScenario { get; set; }

    /// <summary>
    /// Идентификатор сценария тестирования.
    /// </summary>
    [ForeignKey("MethodologyScenario")]
    public Guid MethodologyScenarioId { get; set; }

    /// <summary>
    /// Тип теста.
    /// </summary>
    public RequestTestType TestType { get; set; }

    /// <summary>
    /// Номер теста.
    /// </summary>
    public int TestIndex { get; set; }

    /// <summary>
    /// Выбранные значения параметров теста.
    /// </summary>
    public virtual ICollection<TemplateTestParameterValueRelationEntity> TestParameterValues { get; set; }
}