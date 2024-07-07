using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Менеджер проекта.
/// </summary>
[Table("ProjectManager")]
public class ProjectManagerEntity : EntityBase
{
    /// <summary>
    /// Информация о менеджере проекта.
    /// </summary>
    public virtual UserEntity ProjectManager { get; set; }

    /// <summary>
    /// Идентификатор менеджера проекта.
    /// TODO: Удалить.
    /// </summary>
    [ForeignKey("ProjectManager")]
    public Guid? ProjectManagerId { get; set; }

    /// <summary>
    /// Информация о проекте.
    /// </summary>
    public virtual ProjectEntity Project { get; set; }

    /// <summary>
    /// Идентификатор проекта.
    /// </summary>
    [ForeignKey("Project")]
    public Guid? ProjectId { get; set; }

    /// <summary>
    /// Дата старта курирования проекта.
    /// </summary>
    public DateTime StartDate { get; set; }

    /// <summary>
    /// Дата окончания курирования проекта.
    /// </summary>
    public DateTime? EndDate { get; set; }
}