using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь элемента парсинга и показателя.
/// </summary>
public class MethodologyParsingItem_ResultParameterRelation : EntityBase
{
    /// <summary>
    /// Идентификатор элемента парсинга.
    /// </summary>
    [ForeignKey(nameof(MethodologyParsingItem))]
    public Guid MethodologyParsingItemId { get; set; }

    /// <summary>
    /// Идентификатор показателя.
    /// </summary>
    [ForeignKey(nameof(ResultParameter))]
    public Guid ResultParameterId { get; set; }

    /// <summary>
    /// Элемент парсинга.
    /// </summary>
    public virtual MethodologyParsingItemEntity MethodologyParsingItem { get; set; }

    /// <summary>
    /// Показатель.
    /// </summary>
    public virtual ResultParameterEntity ResultParameter { get; set; }
}