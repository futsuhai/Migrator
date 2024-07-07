using System.ComponentModel.DataAnnotations.Schema;
using MigrationApp.PerformanceAnalyzer.Models.Enums;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Оборудование временно недоступно.
/// </summary>
[Table("EquipmentTemporarilyUnavailableAction")]
public class EquipmentTemporarilyUnavailableActionEntity : EntityBase
{
    /// <summary>
    /// Комментарий.
    /// </summary>
    public string Comment { get; set; }

    /// <summary>
    /// Оборудование.
    /// </summary>
    public virtual EquipmentActionEntity EquipmentAction { get; set; }

    /// <summary>
    /// Идентификатор оборудования.
    /// </summary>
    [Column("EquipmentActionId")]
    [ForeignKey("EquipmentAction")]
    public new Guid Id { get; set; }

    /// <summary>
    /// Причина недоступности.
    /// </summary>
    public EquipmentTemporarilyUnavailableReason Reason { get; set; }
}