using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Результирующие данные по заявке.
/// </summary>
[Table("RequestResultData")]
public class RequestResultDataEntity : EntityBase
{
    /// <summary>
    /// Дополнительные результаты выполнения теста.
    /// </summary>
    public string ParsedDataJson { get; set; }

    /// <summary>
    /// Результат выполнения теста.
    /// </summary>
    public double RawDataResult { get; set; }

    /// <summary>
    /// Строковый результат.
    /// </summary>
    public string StringDataResult { get; set; }

    /// <summary>
    /// Идентификатор показателя, к которому привязан файл.
    /// </summary>
    [ForeignKey(nameof(ResultParameter))]
    public Guid ResultParameterId { get; set; }

    /// <summary>
    /// Идентификатор файла заявки.
    /// </summary>
    [ForeignKey(nameof(RequestFile))]
    public Guid? RequestFileId { get; set; }

    /// <summary>
    /// Идентификатор заявки.
    /// </summary>
    [ForeignKey(nameof(Request))]
    public Guid RequestId { get; set; }

    /// <summary>
    /// Заявка.
    /// </summary>
    public virtual RequestEntity Request { get; set; }

    /// <summary>
    /// Показатель.
    /// </summary>
    public virtual ResultParameterEntity ResultParameter { get; set; }

    /// <summary>
    /// Файл заявки.
    /// </summary>
    public virtual RequestFileEntity RequestFile { get; set; }
}