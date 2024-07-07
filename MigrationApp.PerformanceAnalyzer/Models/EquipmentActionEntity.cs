using System.ComponentModel.DataAnnotations.Schema;
using MigrationApp.PerformanceAnalyzer.Models.Enums;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Действие над оборудованием.
/// </summary>
[Table("EquipmentAction")]
public class EquipmentActionEntity : EntityBase
{
    /// <summary>
    /// Дата измены.
    /// </summary>
    public DateTime ChangeDate { get; set; }

    /// <summary>
    /// Дата конца.
    /// </summary>
    public DateTime EndDate { get; set; }

    /// <summary>
    /// Оборудование.
    /// </summary>
    public virtual EquipmentEntity Equipment { get; set; }

    /// <summary>
    /// Идентификатор оборудования.
    /// </summary>
    [ForeignKey("Equipment")]
    public Guid EquipmentId { get; set; }

    /// <summary>
    /// Дата начала.
    /// </summary>
    public DateTime StartDate { get; set; }

    /// <summary>
    /// Тип действия.
    /// </summary>
    public EquipmentActionType Type { get; set; }

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