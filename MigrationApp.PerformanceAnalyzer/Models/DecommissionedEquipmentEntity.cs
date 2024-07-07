using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Единица оборудования, выведенного из эксплуатации.
/// </summary>
[Table("DecommissionedEquipment")]
public class DecommissionedEquipmentEntity : EntityBase
{
    /// <summary>
    /// Комментарий.
    /// </summary>
    public string Comment { get; set; }

    /// <summary>
    /// Оборудование.
    /// </summary>
    public virtual EquipmentEntity Equipment { get; set; }

    /// <summary>
    /// Идентификатор оборудования.
    /// </summary>
    [Column("EquipmentId")]
    [ForeignKey("Equipment")]
    public new Guid Id { get; set; }

    /// <summary>
    /// Имя пользователя, вывевшего оборудование из себя.
    /// </summary>
    public string UserName { get; set; }
}