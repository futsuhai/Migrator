using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Перевод.
/// </summary>
[Table("Translation")]
public class TranslationEntity : EntityBase
{
    /// <summary>
    /// Перевод.
    /// </summary>
    public virtual TranslationRelationEntity Translation { get; set; }

    /// <summary>
    /// Язык перевода.
    /// </summary>
    public string Language { get; set; }

    /// <summary>
    /// Текст перевода.
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// Идентификатор перевода.
    /// </summary>
    [ForeignKey(nameof(Translation))]
    public Guid TranslationId { get; set; }
}