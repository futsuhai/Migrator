using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь пользователя с избранным продуктом.
/// </summary>
public class UserFavoriteProductRelation : EntityBase
{
    /// <summary>
    /// Пользователь.
    /// </summary>
    public virtual UserEntity User { get; set; }

    /// <summary>
    /// Продукт.
    /// </summary>
    public virtual ProductEntity Product { get; set; }

    /// <summary>
    /// Идентификатор пользователя.
    /// </summary>
    [ForeignKey(nameof(User))]
    public Guid UserId { get; set; }

    /// <summary>
    /// Идентификатор продукта.
    /// </summary>
    [ForeignKey(nameof(Product))]
    public Guid ProductId { get; set; }
}