using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Методология элемента группы заявок.
/// </summary>
[Table("MethodologyBundleItem")]
public class MethodologyBundleItemEntity : EntityBase
{
    /// <summary>
    /// Полное название.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Является ли этот элемент обязательным.
    /// </summary>
    public bool IsRequired { get; set; }

    /// <summary>
    /// Обязательны ли испытания на одной и той же платформе.
    /// </summary>
    public bool IsSamePlatform { get; set; }

    /// <summary>
    /// Методики группы заявок.
    /// </summary>
    public virtual MethodologyBundleEntity MethodologyBundle { get; set; }

    /// <summary>
    /// Идентификатор методики группы заявок.
    /// </summary>
    [ForeignKey("MethodologyBundle")]
    [Required]
    public Guid MethodologyBundleId { get; set; }

    /// <summary>
    /// Допустимиые для этого элемента методики.
    /// </summary>
    public virtual ICollection<MethodologyBundleItemLinkEntity> ItemLinkEntities { get; set; }
}