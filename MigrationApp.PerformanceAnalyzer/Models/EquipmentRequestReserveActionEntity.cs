using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Резервирование по заявке.
/// </summary>
[Table("EquipmentRequestReserveAction")]
public class EquipmentRequestReserveActionEntity : EntityBase
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
    /// Заявка.
    /// </summary>
    [ForeignKey("RequestId")]
    public virtual RequestEntity Request { get; set; }

    /// <summary>
    /// Идентификатор заявки.
    /// </summary>
    public Guid RequestId { get; set; }
}