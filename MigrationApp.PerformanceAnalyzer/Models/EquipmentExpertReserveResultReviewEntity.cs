using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Заметка о результатах деятельности эксперта.
/// </summary>
[Table("EquipmentExpertReserveResultReview")]
public class EquipmentExpertReserveResultReviewEntity : EntityBase
{
    /// <summary>
    /// Дата создания.
    /// </summary>
    public DateTime CreationDate { get; set; }

    /// <summary>
    /// Резерв.
    /// </summary>
    public virtual EquipmentExpertReserveEntity Reserve { get; set; }

    /// <summary>
    /// Идентификатор резерва.
    /// </summary>
    [ForeignKey("Reserve")]
    public Guid ReserveId { get; set; }

    /// <summary>
    /// Текст.
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// Пользователь.
    /// </summary>
    public virtual UserEntity User { get; set; }

    /// <summary>
    /// Пользовательский id.
    /// </summary>
    public Guid UserId { get; set; }
}