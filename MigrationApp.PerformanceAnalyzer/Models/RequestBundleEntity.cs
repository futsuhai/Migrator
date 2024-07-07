using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Группа заявок.
/// </summary>
[Table("RequestBundle")]
public class RequestBundleEntity : EntityBase
{
    /// <summary>
    /// Связка методик, по которой была текущая связка заявок.
    /// </summary>
    public virtual MethodologyBundleEntity Bundle { get; set; }

    /// <summary>
    /// Идентификатор методики, по которой была текущая группа заявок.
    /// </summary>
    [ForeignKey("Bundle")]
    public Guid? BundleId { get; set; } // Не null

    /// <summary>
    /// Заявки, входящие в связку.
    /// </summary>
    public virtual ICollection<RequestBundleItemEntity> BundleItems { get; set; }

    /// <summary>
    /// Полное название.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Файлы отчётов.
    /// </summary>
    public virtual ICollection<RequestBundleStorageFileEntity> ReportFiles { get; set; }
}