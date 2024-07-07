namespace MigrationApp.SearchService.Models;

/// <summary>
/// Продукты, для которых доступно тестирование по методикам.
/// </summary>
public class MethodologyProductRelation
{
    /// <summary>
    /// Методика.
    /// </summary>
    public virtual MethodologyEntity Methodology { get; set; }

    /// <summary>
    /// Продукт.
    /// </summary>
    public virtual ProductEntity Product { get; set; }

    /// <summary>
    /// Id методики.
    /// </summary>
    public Guid MethodologyId { get; set; }

    /// <summary>
    /// Id продукта.
    /// </summary>
    public Guid ProductId { get; set; }
}