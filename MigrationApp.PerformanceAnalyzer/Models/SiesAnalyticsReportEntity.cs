using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Данные аналитических отчетов Sies.
/// </summary>
public class SiesAnalyticsReportEntity : EntityBase
{
    /// <summary>
    /// Идентификатор версии продукта.
    /// </summary>
    public virtual ProductVersionEntity ProductVersion { get; set; }

    /// <summary>
    /// Номер сборки.
    /// </summary>
    public string Build { get; set; }

    /// <summary>
    /// Версия Sdk.
    /// </summary>
    public virtual ParameterValueEntity SdkVerison { get; set; }

    /// <summary>
    /// Версия отчета.
    /// </summary>
    public int Version { get; set; }

    /// <summary>
    /// Файл с данными отчета.
    /// </summary>
    public virtual StorageFileEntity StorageFile { get; set; }

    /// <summary>
    /// Идентификатор версии продукта.
    /// </summary>
    [ForeignKey(nameof(ProductVersion))]
    public Guid ProductVersionId { get; set; }

    /// <summary>
    /// Идентификатор значения параметра "Версия SDK".
    /// </summary>
    [ForeignKey(nameof(SdkVerison))]
    public Guid? SdkVersionId { get; set; }

    /// <summary>
    /// Идентификатор файла с данными отчета.
    /// </summary>
    public Guid StorageFileId { get; set; }
}