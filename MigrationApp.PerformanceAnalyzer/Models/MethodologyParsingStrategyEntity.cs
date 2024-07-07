using System.ComponentModel.DataAnnotations.Schema;
using MigrationApp.PerformanceAnalyzer.Models.Enums;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Конфиг обработки файлов результатов по методике.
/// </summary>
public class MethodologyParsingStrategyEntity
    : EntityBase
{
    /// <summary>
    /// Тип обработки файлов.
    /// </summary>
    public ProcessingStrategyType StrategyType { get; set; }

    /// <summary>
    /// Требуется ли загрузка по порядку.
    /// </summary>
    public bool IsUploadingGradual { get; set; }

    /// <summary>
    /// Поддержка кластера.
    /// </summary>
    public bool IsClusterEnabled { get; set; }

    /// <summary>
    /// Конфиг калькулятора интегрального показателя.
    /// </summary>
    public string IntegralResultCalculatorConfig { get; set; }

    /// <summary>
    /// Идентификатор методики.
    /// </summary>
    [ForeignKey(nameof(Methodology))]
    public Guid MethodologyId { get; set; }

    /// <summary>
    /// Идентификатор калькулятора интегрального показателя.
    /// </summary>
    [ForeignKey(nameof(IntegralResultCalculator))]
    public Guid? IntegralResultCalculatorId { get; set; }

    /// <summary>
    /// Методика.
    /// </summary>
    public virtual MethodologyEntity Methodology { get; set; }

    /// <summary>
    /// Калькулятор интегрального показателя.
    /// </summary>
    public virtual IntegralResultCalculatorEntity IntegralResultCalculator { get; set; }

    /// <summary>
    /// Элементы для обработки.
    /// </summary>
    public virtual ICollection<MethodologyParsingItemEntity> ParsingItems { get; set; }
}