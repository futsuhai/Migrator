using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Перевод для значения параметра.
/// </summary>
[Table("ParameterValue_Translation")]
public class ParameterValueTranslationEntity : EntityBase
{
    /// <summary>
    /// Значение параметра.
    /// </summary>
    [JsonIgnore]
    public virtual ParameterValueEntity ParameterValue { get; set; }

    /// <summary>
    /// Идентификатор значения параметра.
    /// </summary>
    [ForeignKey("ParameterValue")]
    public Guid ParameterValueId { get; set; }

    /// <summary>
    /// Язык.
    /// </summary>
    public string Language { get; set; }

    /// <summary>
    /// Значение.
    /// </summary>
    public string Value { get; set; }
}