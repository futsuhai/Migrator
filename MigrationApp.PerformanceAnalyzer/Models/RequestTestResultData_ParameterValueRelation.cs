using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь результатов тестирования и параметров.
/// </summary>
[Table("RequestTestResultData_ParameterValueRelation")]
public class RequestTestResultData_ParameterValueRelation : EntityBase
{
    /// <summary>
    /// Результат тестирования.
    /// </summary>
    public virtual RequestTestResultDataEntity RequestTestResultData { get; set; }

    /// <summary>
    /// Идентификатор результата тестирования.
    /// </summary>
    [ForeignKey("RequestTestResultData")]
    public Guid RequestTestResultDataId { get; set; }

    /// <summary>
    /// Значение параметра.
    /// </summary>
    public virtual ParameterValueEntity ParameterValue { get; set; }

    /// <summary>
    /// Идентификатор значения параметра.
    /// </summary>
    [ForeignKey("ParameterValue")]
    public Guid ParameterValueId { get; set; }
}