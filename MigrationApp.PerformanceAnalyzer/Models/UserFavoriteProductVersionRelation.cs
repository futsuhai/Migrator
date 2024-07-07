using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связб пользователя с избранной версией продукта.
/// </summary>
public class UserFavoriteProductVersionRelation : EntityBase
{
    /// <summary>
    /// Пользователь.
    /// </summary>
    public virtual UserEntity User { get; set; }

    /// <summary>
    /// Версия продукта.
    /// </summary>
    public virtual ProductVersionEntity ProductVersion { get; set; }

    /// <summary>
    /// Идентификатор пользователя.
    /// </summary>
    [ForeignKey(nameof(User))]
    public Guid UserId { get; set; }

    /// <summary>
    /// Идентификатор версии продукта.
    /// </summary>
    [ForeignKey(nameof(ProductVersion))]
    public Guid ProductVersionId { get; set; }
}