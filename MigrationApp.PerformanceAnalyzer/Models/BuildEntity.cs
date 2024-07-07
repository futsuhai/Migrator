using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Сущность билда.
/// </summary>
[Table("Build")]
public class BuildEntity : EntityBase
{
    /// <summary>
    /// Номер билда.
    /// </summary>
    public string? Number { get; set; }

    /// <summary>
    /// Билд в OVA.
    /// </summary>
    public virtual OvaBuildEntity OvaBuild { get; set; }

    /// <summary>
    /// Заявки.
    /// </summary>
    public virtual ICollection<RequestEntity> Requests { get; set; }
}