using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Информация об актуальной сборке версии продукта.
/// </summary>
[Table("ProductVersion_ActualBuild")]
public class ProductVersion_ActualBuildInfoEntity : EntityBase
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
    public int ActualAssemblyNumber { get; set; }

    /// <summary>
    /// Номер последней сборки.
    /// </summary>
    public int LastAssemblyNumber { get; set; }
}