using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Офис.
/// </summary>
[Table("Office")]
public class OfficeEntity : EntityBase
{
    /// <summary>
    /// Название офиса.
    /// </summary>
    public virtual TranslationRelationEntity Name { get; set; }

    /// <summary>
    /// Город.
    /// </summary>
    public virtual CityEntity City { get; set; }

    /// <summary>
    /// Идентификатор имени.
    /// </summary>
    [ForeignKey(nameof(Name))]
    public Guid NameId { get; set; }

    /// <summary>
    /// Идентификатор города.
    /// </summary>
    [ForeignKey("City")]
    public Guid CityId { get; set; }
}