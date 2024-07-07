using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Группа продуктов.
/// </summary>
[Table("ProductGroup")]
public class ProductGroupEntity : EntityBase
{
    /// <summary>
    /// Название группы продуктов.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Короткое название группы продуктов.
    /// </summary>
    public string ShortName { get; set; }

    /// <summary>
    /// Привязанные продукты.
    /// </summary>
    public virtual ICollection<ProductEntity> Products { get; set; }
}