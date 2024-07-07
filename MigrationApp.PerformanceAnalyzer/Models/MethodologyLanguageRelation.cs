using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Привязка возможного языка для методики.
/// </summary>
[Table("Methodology_LanguageRelation")]
public class MethodologyLanguageRelation : EntityBase
{
    /// <summary>
    /// Методика тестирования.
    /// </summary>
    public virtual MethodologyEntity Methodology { get; set; }

    /// <summary>
    /// Идентификатор методики.
    /// </summary>
    [ForeignKey("Methodology")]
    public Guid MethodologyId { get; set; }

    /// <summary>
    /// Язык.
    /// </summary>
    public string Language { get; set; }
}