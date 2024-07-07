using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь методики и блока отчета.
/// </summary>
public class Methodology_ReportPartRelation : EntityBase
{
    /// <summary>
    /// Порядковый номер блока.
    /// </summary>
    public int OrderIndex { get; set; }

    /// <summary>
    /// Методика.
    /// </summary>
    public virtual MethodologyEntity Methodology { get; set; }

    /// <summary>
    /// Блок отчета.
    /// </summary>
    public virtual ReportPartEntity ReportPart { get; set; }

    /// <summary>
    /// Идентификатор методики.
    /// </summary>
    [ForeignKey(nameof(Methodology))]
    public Guid MethodologyId { get; set; }

    /// <summary>
    /// Идентификатор блока отчета.
    /// </summary>
    [ForeignKey(nameof(ReportPart))]
    public Guid ReportPartId { get; set; }
}