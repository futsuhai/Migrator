using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Тестовое окружение.
/// </summary>
[Table("TestEnvironment")]
public class TestEnvironmentEntity : EntityBase
{
    /// <summary>
    /// Название тестового окружения.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Пользователь, объявивший данную версию ТО устаревшей.
    /// </summary>
    public virtual UserEntity UserArchivedVersion { get; set; }

    /// <summary>
    /// Идентификатор пользователя, объявившего данную версию ТО устаревшей.
    /// </summary>
    [ForeignKey("UserArchivedVersion")]
    public Guid? UserArchivedVersionId { get; set; }

    /// <summary>
    /// Более новая версия ТО.
    /// </summary>
    public virtual TestEnvironmentEntity NewerVersion { get; set; }

    /// <summary>
    /// Идентификатор более новой версии ТО.
    /// </summary>
    [ForeignKey("NewerVersion")]
    public Guid? NewerVersionId { get; set; }

    /// <summary>
    /// Дата и время объявления версии ТО устаревшей.
    /// </summary>
    public DateTime? ArchivedDate { get; set; }

    /// <summary>
    /// Связи с объектами.
    /// </summary>
    public virtual ICollection<TestEnvironmentObjectTestEnvironmentRelation> TestEnvironmentObjectRelations { get; set; } = new List<TestEnvironmentObjectTestEnvironmentRelation>();

    /// <summary>
    /// Связи со стендами.
    /// </summary>
    public virtual ICollection<MethodologyStand_TestEnvironmentRelation> MethodologyStandTestEnvironmentRelations { get; set; } = new List<MethodologyStand_TestEnvironmentRelation>();
}