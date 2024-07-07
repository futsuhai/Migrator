using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Идентифицирующие строчки для параметров.
/// </summary>
[Table("Methodology_ParameterValueIdentify")]
public class MethodologyParameterValueIdentify : EntityBase
{
    /// <summary>
    /// Идентифицирующая строка.
    /// </summary>
    public string IdentifyString { get; set; }

    /// <summary>
    /// Значения параметра.
    /// </summary>
    public virtual ParameterValueEntity ParameterValue { get; set; }

    /// <summary>
    /// Идентификатор значения параметра.
    /// </summary>
    [ForeignKey("ParameterValue")]
    public Guid ParameterValueId { get; set; }

    /// <summary>
    /// Методика.
    /// </summary>
    public virtual ResultParameterEntity ResultParameter { get; set; }

    /// <summary>
    /// Идентификатор методики.
    /// </summary>
    [ForeignKey("ResultParameter")]
    public Guid ResultParameterId { get; set; }
}