using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Элемент группы заявок.
/// </summary>
[Table("RequestBundleItem")]
public class RequestBundleItemEntity : EntityBase
{
    /// <summary>
    /// Методология элемента, по образцу которого создан элемент.
    /// </summary>
    public virtual MethodologyBundleItemEntity MethodologyBundleItem { get; set; }

    /// <summary>
    /// Идентификатор методологии элемента, по образцу которого создан элемент.
    /// </summary>
    [ForeignKey("MethodologyBundleItem")]
    [Required]
    public Guid MethodologyBundleItemId { get; set; }

    /// <summary>
    /// Заявка, к которой привязан элемент.
    /// </summary>
    public virtual RequestEntity Request { get; set; }

    /// <summary>
    /// Группа заявок.
    /// </summary>
    public virtual RequestBundleEntity RequestBundle { get; set; }

    /// <summary>
    /// Идентификатор группы заявок.
    /// </summary>
    [ForeignKey("RequestBundle")]
    [Required]
    public Guid RequestBundleId { get; set; }

    /// <summary>
    /// Идентификатор заявки, к которой привязан элемент.
    /// </summary>
    [ForeignKey("Request")]
    [Required]
    public Guid RequestId { get; set; }
}