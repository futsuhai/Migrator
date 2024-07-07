using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrationApp.PerformanceAnalyzer.Models.Enums;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Резерв эксперта.
/// </summary>
[Table("EquipmentExpertReserve")]
public class EquipmentExpertReserveEntity : EntityBase
{
    /// <summary>
    /// Список экшенов для резерва.
    /// </summary>
    public virtual ICollection<EquipmentExpertReserveActionEntity> Actions { get; set; }

    /// <summary>
    /// Цвет екшена.
    /// </summary>
    public EquipmentActionColor Color { get; set; }

    /// <summary>
    /// Комментарий.
    /// </summary>
    public string Comment { get; set; }

    /// <summary>
    /// Дата создания.
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Номер заказа.
    /// </summary>
    public int Number { get; set; }

    /// <summary>
    /// Приоритет.
    /// </summary>
    public EquipmentExpertReservePriority Priority { get; set; }

    /// <summary>
    /// Дата освобождения.
    /// </summary>
    public DateTime? ReleaseDate { get; set; }

    /// <summary>
    /// История заметок.
    /// </summary>
    public virtual ICollection<EquipmentExpertReserveResultReviewEntity> ResultReviewHistory { get; set; }

    /// <summary>
    /// Ссылочка на задачу в TFS.
    /// </summary>
    public string TfsLink { get; set; }

    /// <summary>
    /// Заголовок.
    /// </summary>
    [MaxLength(150)]
    public string Title { get; set; }

    /// <summary>
    /// Клиент.
    /// </summary>
    public virtual UserEntity User { get; set; }

    /// <summary>
    /// Идентификатор клиента.
    /// </summary>
    [ForeignKey("User")]
    public Guid UserId { get; set; }
}