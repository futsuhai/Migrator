using System.ComponentModel.DataAnnotations.Schema;
using MigrationApp.PerformanceAnalyzer.Models.Enums;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Показатель методики.
/// </summary>
[Table("ResultParameter")]
public class ResultParameterEntity : EntityBase
{
    /// <summary>
    /// Полное имя.
    /// </summary>
    public string FullName { get; set; }

    /// <summary>
    /// Имя для UI.
    /// </summary>
    public string UiName { get; set; }

    /// <summary>
    /// Единицы измерения.
    /// </summary>
    public string Units { get; set; }

    /// <summary>
    /// Код показателя (для конфигов).
    /// </summary>
    public string ResultParameterCode { get; set; }

    /// <summary>
    /// Направление улучшения значения показателя.
    /// </summary>
    public ResultParameterImprovementDirection ImprovementDirection { get; set; }

    /// <summary>
    /// Группа показателей.
    /// </summary>
    public virtual ResultParameterGroupEntity ResultParameterGroup { get; set; }

    /// <summary>
    /// Переводы для показателя.
    /// </summary>
    public virtual ICollection<ResultParameterTranslationEntity> Translations { get; set; }

    /// <summary>
    /// Идентификатор группы показателей.
    /// </summary>
    [ForeignKey("ResultParameterGroup")]
    public Guid? ResultParameterGroupId { get; set; }
}