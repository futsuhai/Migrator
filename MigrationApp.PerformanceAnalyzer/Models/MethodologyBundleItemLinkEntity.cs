using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь элемента группы заявок с методологией.
/// </summary>
[Table("MethodologyBundleItemLink")]
public class MethodologyBundleItemLinkEntity : EntityBase
{
    /// <summary>
    /// Методология для элемента.
    /// </summary>
    public virtual MethodologyEntity Methodology { get; set; }

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
    /// Идентификатор методологии для элемента.
    /// </summary>
    [ForeignKey("Methodology")]
    [Required]
    public Guid MethodologyId { get; set; }
}