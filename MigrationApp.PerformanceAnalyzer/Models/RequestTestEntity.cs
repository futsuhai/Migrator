using System.ComponentModel.DataAnnotations.Schema;
using MigrationApp.PerformanceAnalyzer.Models.Enums;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Сущность теста заявки.
/// </summary>
[Table("RequestTest")]
public class RequestTestEntity : EntityBase
{
    /// <summary>
    /// Заявка на тестирование.
    /// </summary>
    public virtual RequestEntity Request { get; set; }

    /// <summary>
    /// Идентификатор заявки.
    /// </summary>
    [ForeignKey("Request")]
    public Guid RequestId { get; set; }

    /// <summary>
    /// Выбранные значения параметров теста.
    /// </summary>
    public virtual ICollection<RequestTestParameterValueRelation> RequestTestParameterValues { get; set; }

    /// <summary>
    /// Результаты по тесту.
    /// </summary>
    public virtual ICollection<RequestTestResultDataEntity> RequestTestResultDataEntities { get; set; }

    /// <summary>
    /// Статус теста.
    /// </summary>
    [Column("StatusId")]
    public RequestTestStatus Status { get; set; }

    /// <summary>
    /// Номер теста.
    /// </summary>
    public int TestIndex { get; set; }

    /// <summary>
    /// Тип теста.
    /// </summary>
    public RequestTestType Type { get; set; }
}