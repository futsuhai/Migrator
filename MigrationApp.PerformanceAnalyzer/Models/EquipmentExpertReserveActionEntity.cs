using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Действие по заказу оборудования экспертом.
/// </summary>
[Table("EquipmentExpertReserveAction")]
public class EquipmentExpertReserveActionEntity : EntityBase
{
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
    /// Заказ эксперта.
    /// </summary>
    public virtual EquipmentExpertReserveEntity Reserve { get; set; }

    /// <summary>
    /// Идентификатор заказа.
    /// </summary>
    [ForeignKey("Reserve")]
    public Guid ReserveId { get; set; }
}