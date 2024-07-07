using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь пользователя с избранной сборкой.
/// </summary>
public class UserFavoriteBuildRelation : EntityBase
{
    /// <summary>
    /// Пользователь.
    /// </summary>
    public virtual UserEntity User { get; set; }

    /// <summary>
    /// Сборка.
    /// </summary>
    public virtual CompositeBuildInfoEntity Build { get; set; }

    /// <summary>
    /// Идентификатор пользователя.
    /// </summary>
    [ForeignKey(nameof(User))]
    public Guid UserId { get; set; }

    /// <summary>
    /// Идентификатор сборки.
    /// </summary>
    [ForeignKey(nameof(Build))]
    public Guid BuildId { get; set; }
}