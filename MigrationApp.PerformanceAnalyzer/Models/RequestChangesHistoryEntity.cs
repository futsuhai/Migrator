using System.ComponentModel.DataAnnotations.Schema;
using MigrationApp.PerformanceAnalyzer.Models.Enums;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// История изменения заявки.
/// </summary>
[Table("RequestChangesHistory")]
public class RequestChangesHistoryEntity : EntityBase
{
    /// <summary>
    /// Дата изменения.
    /// </summary>
    public DateTime ChangeDate { get; set; }

    /// <summary>
    /// Новый статус.
    /// </summary>
    public RequestStatus? NewStatus { get; set; }

    /// <summary>
    /// Старый статус.
    /// </summary>
    public RequestStatus? OldStatus { get; set; }

    /// <summary>
    /// Вывод по заявке.
    /// </summary>
    public string Conclusion { get; set; }

    /// <summary>
    /// Заявка.
    /// </summary>
    public virtual RequestEntity Request { get; set; }

    /// <summary>
    /// Идентификатор заявки.
    /// </summary>
    [ForeignKey("Request")]
    public Guid RequestId { get; set; }
}