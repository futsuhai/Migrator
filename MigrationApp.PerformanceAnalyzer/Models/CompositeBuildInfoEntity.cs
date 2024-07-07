using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Информация о сборке продукта, полученная из сервиса сборок ОВА или базы данных VPA.
/// </summary>
[Table("ProductVersion_CompositeBuild")]
public class CompositeBuildInfoEntity : EntityBase
{
    /// <summary>
    /// Версия продукта.
    /// </summary>
    public virtual ProductVersionEntity ProductVersion { get; set; }

    /// <summary>
    /// Идентификатор версии продукта.
    /// </summary>
    [ForeignKey("ProductVersion")]
    public Guid ProductVersionId { get; set; }

    /// <summary>
    /// Номер сборки.
    /// </summary>
    public int AssemblyNumber { get; set; }

    /// <summary>
    /// Идентификатор на сервисе сборок.
    /// </summary>
    public string OvaBuildId { get; set; }

    /// <summary>
    /// Статус.
    /// </summary>
    public string State { get; set; }
}