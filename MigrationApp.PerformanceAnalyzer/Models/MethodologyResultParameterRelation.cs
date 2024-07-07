using System.ComponentModel.DataAnnotations.Schema;
using MigrationApp.PerformanceAnalyzer.Models.Enums;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Таблица связей методики и показателя.
/// </summary>
[Table("Methodology_ResultParameterRelation")]
public class MethodologyResultParameterRelation : EntityBase
{
    /// <summary>
    /// Порядковый номер.
    /// </summary>
    public int OrderNumber { get; set; }

    /// <summary>
    /// Контекст привязки показателя.
    /// </summary>
    public ResultParameterBindingContext BindingContext { get; set; }

    /// <summary>
    /// Является ли показатель интегральным.
    /// </summary>
    public bool IsIntegral { get; set; }

    /// <summary>
    /// Показывается ли показатель в графиках.
    /// </summary>
    public bool ShouldShowGraph { get; set; } = true;

    /// <summary>
    /// Теоретический максимум.
    /// </summary>
    public double? TheoreticalMax { get; set; }

    /// <summary>
    /// Показатель.
    /// </summary>
    public virtual ResultParameterEntity ResultParameter { get; set; }

    /// <summary>
    /// Методика.
    /// </summary>
    public virtual MethodologyEntity Methodology { get; set; }

    /// <summary>
    /// Парсер.
    /// </summary>
    public virtual DataParserEntity DataParser { get; set; }

    /// <summary>
    /// Значение параметра, активирующее показатель.
    /// </summary>
    public virtual ParameterValueEntity TriggeringParameterValue { get; set; }

    /// <summary>
    /// Алгоритм расчёта теоретического максимума.
    /// </summary>
    public virtual TheoreticalMaximumAlgorithmEntity TheoreticalMaximumAlgorithm { get; set; }

    /// <summary>
    /// Идентификатор показателя.
    /// </summary>
    [ForeignKey(nameof(ResultParameter))]
    public Guid ResultParameterId { get; set; }

    /// <summary>
    /// Идентификатор методики.
    /// </summary>
    [ForeignKey(nameof(Methodology))]
    public Guid MethodologyId { get; set; }

    /// <summary>
    /// Идентификатор парсера.
    /// </summary>
    [ForeignKey(nameof(DataParser))]
    public Guid? DataParserId { get; set; }

    /// <summary>
    /// Идентификатор значения параметра, активирующего показатель.
    /// </summary>
    [ForeignKey(nameof(TriggeringParameterValue))]
    public Guid? TriggeringParameterValueId { get; set; }

    /// <summary>
    /// Идентификатор алгоритма расчёта теоретического максимума.
    /// </summary>
    [ForeignKey(nameof(TheoreticalMaximumAlgorithm))]
    public Guid? TheoreticalMaximumAlgorithmId { get; set; }
}