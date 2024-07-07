using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Перевод для параметра.
/// </summary>
[Table("Parameter_Translation")]
public class ParameterTranslationEntity : EntityBase
{
    /// <summary>
    /// Параметр.
    /// </summary>
    [JsonIgnore]
    public virtual ParameterEntity Parameter { get; set; }

    /// <summary>
    /// Идентификатор параметра.
    /// </summary>
    [ForeignKey("Parameter")]
    public Guid ParameterId { get; set; }

    /// <summary>
    /// Язык.
    /// </summary>
    public string Language { get; set; }

    /// <summary>
    /// Название параметра.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Пояснение.
    /// </summary>
    public string Note { get; set; }

    /// <summary>
    /// Короткое название параметра (для GUI).
    /// </summary>
    public string ShortName { get; set; }
}