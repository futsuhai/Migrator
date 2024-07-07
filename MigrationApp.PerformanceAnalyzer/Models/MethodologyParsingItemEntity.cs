using System.ComponentModel.DataAnnotations.Schema;
using MigrationApp.PerformanceAnalyzer.Models.Enums;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Элемент парсинга стратегии обработки файлов методики.
/// </summary>
public class MethodologyParsingItemEntity : EntityBase
{
    /// <summary>
    /// Регулярное выражение для названия файла.
    /// </summary>
    public string FileNamePattern { get; set; }

    /// <summary>
    /// Подсказка к загрузке файла.
    /// </summary>
    public string Hint { get; set; }

    /// <summary>
    /// Порядковый номер.
    /// </summary>
    public int OrderNumber { get; set; }

    /// <summary>
    /// Количество требуемых файлов.
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Конфиг для экстрактора данных.
    /// </summary>
    public string FileParsingDataExtractorConfig { get; set; }

    /// <summary>
    /// Контекст привязки.
    /// </summary>
    public ParsingItemBindingContext BindingContext { get; set; }

    /// <summary>
    /// Идентификатор стратегии обработки файлов методики.
    /// </summary>
    [ForeignKey(nameof(MethodologyParsingStrategy))]
    public Guid MethodologyParsingStrategyId { get; set; }

    /// <summary>
    /// Мдентификатор экстрактора данных.
    /// </summary>
    [ForeignKey(nameof(FileParsingDataExtractor))]
    public Guid FileParsingDataExtractorId { get; set; }

    /// <summary>
    /// Стратегия обработки файлов результатов.
    /// </summary>
    public virtual MethodologyParsingStrategyEntity MethodologyParsingStrategy { get; set; }

    /// <summary>
    /// Экстрактор данных.
    /// </summary>
    public virtual FileParsingDataExtractorEntity FileParsingDataExtractor { get; set; }

    /// <summary>
    /// Валидаторы полученных данных.
    /// </summary>
    public virtual ICollection<MethodologyParsingItem_ParsedResultsValidatorRelation> ValidatorRelations { get; set; }

    /// <summary>
    /// Показатели в файле.
    /// </summary>
    public virtual ICollection<MethodologyParsingItem_ResultParameterRelation> ResultParameterRelations { get; set; }
}