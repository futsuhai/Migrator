using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Схема стенда.
/// </summary>
[Table("MethodologyStand")]
public class MethodologyStandEntity : EntityBase
{
    /// <summary>
    /// Описание стенда.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Методика.
    /// </summary>
    public virtual MethodologyEntity Methodology { get; set; }

    /// <summary>
    /// Привязанные файлы методики.
    /// </summary>
    public virtual ICollection<MethodologyStand_MethodologyFileRelation> MethodologyFiles { get; set; } = new List<MethodologyStand_MethodologyFileRelation>();

    /// <summary>
    /// Идентификатор методики.
    /// </summary>
    [ForeignKey("Methodology")]
    public Guid MethodologyId { get; set; }

    /// <summary>
    /// Активирующие значения.
    /// </summary>
    public virtual ICollection<MethodologyStandTrigger> Triggers { get; set; } = new List<MethodologyStandTrigger>();

    /// <summary>
    /// Тестовые окружения.
    /// </summary>
    public virtual ICollection<MethodologyStand_TestEnvironmentRelation> TestEnvironments { get; set; } = new List<MethodologyStand_TestEnvironmentRelation>();

    /// <summary>
    /// Идентификатор рекомендованного тестового окружения.
    /// </summary>
    public Guid RecommendedTestEnvironmentId { get; set; }

    /// <summary>
    /// Количество необходимых объектов тестирования.
    /// </summary>
    public int HardwarePlatformCount { get; set; }
}