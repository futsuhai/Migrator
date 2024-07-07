using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Локация.
/// </summary>
[Table("Location")]
public class LocationEntity : EntityBase
{
    /// <summary>
    /// Название.
    /// </summary>
    public virtual TranslationRelationEntity Name { get; set; }

    /// <summary>
    /// Офис.
    /// </summary>
    public virtual OfficeEntity Office { get; set; }

    /// <summary>
    /// Список связанных правил доступа.
    /// </summary>
    public virtual ICollection<LocationAccessRightEntity> TesterAccessRules { get; set; }

    /// <summary>
    /// Идентификатор названия.
    /// </summary>
    [ForeignKey(nameof(Name))]
    public Guid NameId { get; set; }

    /// <summary>
    /// Идентификатор Офиса.
    /// </summary>
    [ForeignKey(nameof(Office))]
    public Guid OfficeId { get; set; }
}