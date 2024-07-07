using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Результаты тестирования по методикам производительности для сборки версии продукта.
/// </summary>
[Table("ProductVersion_Build_Perf_Result")]
public class ProductVersion_Build_Perf_ResultsEntity : EntityBase
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
    /// Дата последнего тестирования на производительность.
    /// </summary>
    public DateTime LastTestTime { get; set; }

    /// <summary>
    /// Статус.
    /// </summary>
    public string Status { get; set; }
}