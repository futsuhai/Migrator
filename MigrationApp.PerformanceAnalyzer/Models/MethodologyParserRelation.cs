using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связи методик с парсерами.
/// </summary>
public class MethodologyParserRelation : EntityBase
{
    /// <summary>
    /// Методика.
    /// </summary>
    public virtual MethodologyEntity Methodology { get; set; }

    /// <summary>
    /// Идентификатор парсера.
    /// </summary>
    public Guid ParserId { get; set; }

    /// <summary>
    /// Порядковый номер парсера в методике.
    /// </summary>
    public int OrderIndex { get; set; }

    /// <summary>
    /// Идентификатор методики.
    /// </summary>
    [ForeignKey(nameof(Methodology))]
    public Guid MethodologyId { get; set; }
}