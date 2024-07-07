using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Проект.
/// </summary>
[Table("Project")]
public class ProjectEntity : EntityBase
{
    /// <summary>
    /// Название Проекта.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// История менеджеров проекта.
    /// </summary>
    public virtual ICollection<ProjectManagerEntity> ProjectManagers { get; set; }

    /// <summary>
    /// Дата старта проекта.
    /// </summary>
    public DateTime? StartProjectDate { get; set; }

    /// <summary>
    /// Связи пользователей и проектов.
    /// </summary>
    public virtual ICollection<UserProjectRelation> Users { get; set; }
}