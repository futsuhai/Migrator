using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Группа показателей.
/// </summary>
[Table("ResultParameterGroup")]
public class ResultParameterGroupEntity : EntityBase
{
    /// <summary>
    /// Имя.
    /// </summary>
    public virtual TranslationRelationEntity Name { get; set; }

    /// <summary>
    /// Описание.
    /// </summary>
    public virtual TranslationRelationEntity Description { get; set; }

    /// <summary>
    /// Показатели.
    /// </summary>
    public virtual ICollection<ResultParameterEntity> ResultParameters { get; set; }

    /// <summary>
    /// Имя.
    /// </summary>
    [ForeignKey(nameof(Name))]
    public Guid NameId { get; set; }

    /// <summary>
    /// Описание.
    /// </summary>
    [ForeignKey(nameof(Description))]
    public Guid DescriptionId { get; set; }
}