using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь пользоватеелй и проектов.
/// </summary>
[Table("User_ProjectRelation")]
public class UserProjectRelation : EntityBase
{
    /// <summary>
    /// Проект.
    /// </summary>
    public virtual ProjectEntity Project { get; set; }

    /// <summary>
    /// Пользователь.
    /// </summary>
    public virtual UserEntity User { get; set; }

    /// <summary>
    /// Id проекта.
    /// </summary>
    [ForeignKey(nameof(Project))]
    public Guid ProjectId { get; set; }

    /// <summary>
    /// Id пользователя.
    /// </summary>
    [ForeignKey(nameof(User))]
    public Guid UserId { get; set; }
}