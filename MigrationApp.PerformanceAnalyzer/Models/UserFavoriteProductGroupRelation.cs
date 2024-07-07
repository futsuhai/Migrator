using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь пользователя с избранной группой продуктов.
/// </summary>
public class UserFavoriteProductGroupRelation : EntityBase
{
    /// <summary>
    /// Пользователь.
    /// </summary>
    public virtual UserEntity User { get; set; }

    /// <summary>
    /// Группа продуктов.
    /// </summary>
    public virtual ProductGroupEntity ProductGroup { get; set; }

    /// <summary>
    /// Идентификатор пользователя.
    /// </summary>
    [ForeignKey(nameof(User))]
    public Guid UserId { get; set; }

    /// <summary>
    /// Идентификатор группы продуктов.
    /// </summary>
    [ForeignKey(nameof(ProductGroup))]
    public Guid ProductGroupId { get; set; }
}