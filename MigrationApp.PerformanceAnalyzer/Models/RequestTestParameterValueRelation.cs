using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь теста заявки и значения параметра.
/// </summary>
[Table("RequestTest_ParameterValueRelation")]
public class RequestTestParameterValueRelation : EntityBase
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
    /// Тест в заявке.
    /// </summary>
    public virtual RequestTestEntity RequestTest { get; set; }

    /// <summary>
    /// Идентификатор теста в заявке.
    /// </summary>
    [ForeignKey("RequestTest")]
    public Guid RequestTestId { get; set; }
}