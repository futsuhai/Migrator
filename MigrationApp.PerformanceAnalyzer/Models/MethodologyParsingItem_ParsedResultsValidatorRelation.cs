using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь элемента парсинга и валидатора данных.
/// </summary>
public class MethodologyParsingItem_ParsedResultsValidatorRelation : EntityBase
{
    /// <summary>
    /// Конфигурация для валидатора.
    /// </summary>
    public string Config { get; set; }

    /// <summary>
    /// Идентификатор элемента парсинга.
    /// </summary>
    [ForeignKey(nameof(MethodologyParsingItem))]
    public Guid MethodologyParsingItemId { get; set; }

    /// <summary>
    /// Идентификатор валидатора.
    /// </summary>
    [ForeignKey(nameof(ParsedResultsValidator))]
    public Guid ParsedResultsValidatorId { get; set; }

    /// <summary>
    /// Элемент парсинга.
    /// </summary>
    public virtual MethodologyParsingItemEntity MethodologyParsingItem { get; set; }

    /// <summary>
    /// Валидатор.
    /// </summary>
    public virtual ParsedResultsValidatorEntity ParsedResultsValidator { get; set; }
}