using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Город.
/// </summary>
[Table("City")]
public class CityEntity : EntityBase
{
    /// <summary>
    /// Название города.
    /// </summary>
    public virtual TranslationRelationEntity Name { get; set; }

    /// <summary>
    /// Идентификатор имени.
    /// </summary>
    [ForeignKey(nameof(Name))]
    public Guid NameId { get; set; }
}