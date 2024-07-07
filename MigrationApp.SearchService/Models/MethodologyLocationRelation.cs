namespace MigrationApp.SearchService.Models;

/// <summary>
/// Локации, для которых доступно тестирование по методикам.
/// </summary>
public class MethodologyLocationRelation
{
    /// <summary>
    /// Методика.
    /// </summary>
    public virtual MethodologyEntity Methodology { get; set; }

    /// <summary>
    /// Идентификатор методики.
    /// </summary>
    public Guid MethodologyId { get; set; }

    /// <summary>
    /// Идентификатор локации.
    /// </summary>
    public Guid LocationId { get; set; }
}