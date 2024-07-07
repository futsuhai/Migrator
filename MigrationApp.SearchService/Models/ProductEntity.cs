using MigrationApp.SearchService.Models.Enums;

namespace MigrationApp.SearchService.Models;

/// <summary>
/// Продукты.
/// </summary>
public class ProductEntity
{
    /// <summary>
    /// Id продукта.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Название продукта.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Категория продукта.
    /// </summary>
    public ProductCategory ProductCategory { get; set; }

    /// <summary>
    /// Методики.
    /// </summary>
    public virtual ICollection<MethodologyProductRelation> Methodologies { get; set; }
}