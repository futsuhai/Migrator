using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь Шаблонный тест - значение параметра.
/// </summary>
[Table("TemplateTest_ParameterValue")]
public class TemplateTestParameterValueRelationEntity : EntityBase
{
    /// <summary>
    /// Значение параметра.
    /// </summary>
    public virtual ParameterValueEntity ParameterValue { get; set; }

    /// <summary>
    /// Значения параметра.
    /// </summary>
    [ForeignKey("ParameterValue")]
    public Guid ParameterValueId { get; set; }

    /// <summary>
    /// Тест в шаблоне.
    /// </summary>
    public virtual TemplateTestEntity TemplateTest { get; set; }

    /// <summary>
    /// Идентификатор теста в шаблоне.
    /// </summary>
    [ForeignKey("TemplateTest")]
    public Guid TemplateTestId { get; set; }
}