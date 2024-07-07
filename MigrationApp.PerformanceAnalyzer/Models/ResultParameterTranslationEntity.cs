using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Перевод для показателя.
/// </summary>
[Table("ResultParameterTranslation")]
public class ResultParameterTranslationEntity : EntityBase
{
    /// <summary>
    /// Показатель.
    /// </summary>
    [JsonIgnore]
    public virtual ResultParameterEntity ResultParameter { get; set; }

    /// <summary>
    /// Идентификатор показателя.
    /// </summary>
    [ForeignKey("ResultParameter")]
    public Guid ResultParameterId { get; set; }

    /// <summary>
    /// Язык.
    /// </summary>
    public string Language { get; set; }

    /// <summary>
    /// Полное имя.
    /// </summary>
    public string FullName { get; set; }

    /// <summary>
    /// Имя для UI.
    /// </summary>
    public string UiName { get; set; }

    /// <summary>
    /// Единицы измерения.
    /// </summary>
    public string Units { get; set; }
}