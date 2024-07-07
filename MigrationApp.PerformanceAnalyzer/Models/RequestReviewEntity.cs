using System.ComponentModel.DataAnnotations.Schema;
using MigrationApp.PerformanceAnalyzer.Models.Enums;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Ревью заявки.
/// </summary>
[Table("RequestReview")]
public class RequestReviewEntity : EntityBase
{
    /// <summary>
    /// Комментарий.
    /// </summary>
    public string Comment { get; set; }

    /// <summary>
    /// Дата создания.
    /// </summary>
    public DateTime CreationDate { get; set; }

    /// <summary>
    /// Является ли комментарием эксперта.
    /// </summary>
    public bool IsExpertComment { get; set; }

    /// <summary>
    /// Заявка забракована или одобрена.
    /// </summary>
    public RequestReviewStatus ReviewStatus { get; set; }

    /// <summary>
    /// Заявка.
    /// </summary>
    public virtual RequestEntity Request { get; set; }

    /// <summary>
    /// Идентификатор заявки.
    /// </summary>
    [ForeignKey("Request")]
    public Guid RequestId { get; set; }

    /// <summary>
    /// Пользователь.
    /// </summary>
    public virtual UserEntity User { get; set; }

    /// <summary>
    /// Идентификатор пользователя.
    /// </summary>
    [ForeignKey("User")]
    public Guid UserId { get; set; }
}