using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь тестового окружения и объекта тестового окружения.
/// </summary>
[Table("TheoreticalMaximum_TestEnvironment")]
public class TestEnvironmentTheoreticalMaximumEntity : EntityBase
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
    /// Результирующие параметры.
    /// </summary>
    public virtual ResultParameterEntity ResultParameter { get; set; }

    /// <summary>
    /// Идентификатор результирующего параметра.
    /// </summary>
    [ForeignKey("ResultParameter")]
    public Guid ResultParameterId { get; set; }

    /// <summary>
    /// Теоретический максимум.
    /// </summary>
    public double TheoreticalMaximum { get; set; }
}