using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь между схемой стенда и тестовым окружением.
/// </summary>
[Table("MethodologyStand_TestEnvironmentRelation")]
public class MethodologyStand_TestEnvironmentRelation : EntityBase
{
    /// <summary>
    /// Тестовое окружение.
    /// </summary>
    public virtual TestEnvironmentEntity TestEnvironment { get; set; }

    /// <summary>
    /// Идентификатор тестового окружения.
    /// </summary>
    [ForeignKey("TestEnvironment")]
    public Guid TestEnvironmentId { get; set; }

    /// <summary>
    /// Схема стенда.
    /// </summary>
    public virtual MethodologyStandEntity MethodologyStand { get; set; }

    /// <summary>
    /// Идентификатор схемы стенда.
    /// </summary>
    [ForeignKey("MethodologyStand")]
    public Guid MethodologyStandId { get; set; }
}