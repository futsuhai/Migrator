using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь тестового окружения и объекта тестового окружения.
/// </summary>
[Table("TestEnvironment_ObjectTestEnvironmentRelation")]
public class TestEnvironmentObjectTestEnvironmentRelation : EntityBase
{
    /// <summary>
    /// Объект тестового окружения.
    /// </summary>
    public virtual ObjectTestEnvironmentEntity ObjectTestEnvironment { get; set; }

    /// <summary>
    /// Количество ОТО в ТО.
    /// </summary>
    public int ObjectTestEnvironmentCount { get; set; }

    /// <summary>
    /// Идентификатор объекта тестового окружения.
    /// </summary>
    [ForeignKey("ObjectTestEnvironment")]
    public Guid ObjectTestEnvironmentId { get; set; }

    /// <summary>
    /// Порядковый номер объекта тестового окружения.
    /// </summary>
    public int? ObjectTestEnvironmentIndex { get; set; }

    /// <summary>
    /// Название ОТО на схеме стенда (может быть несколько названий через запятую).
    /// </summary>
    public string ObjectTestEnvironmentNamesOnScheme { get; set; }

    /// <summary>
    /// Тестовое окружение.
    /// </summary>
    public virtual TestEnvironmentEntity TestEnvironment { get; set; }

    /// <summary>
    /// Идентификатор тестового окружения.
    /// </summary>
    [ForeignKey("TestEnvironment")]
    public Guid TestEnvironmentId { get; set; }
}