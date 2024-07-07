using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Feature Set.
/// </summary>
[Table("FeatureSet")]
public class FeatureSetEntity : EntityBase
{
    /// <summary>
    /// Удалён ли.
    /// </summary>
    public bool IsDeleted { get; set; }

    /// <summary>
    /// Продукты.
    /// </summary>
    public virtual ICollection<ProductFeatureSetRelationEntity> Products { get; set; }

    /// <summary>
    /// Название.
    /// </summary>
    public string Title { get; set; }
}