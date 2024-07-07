using System.ComponentModel.DataAnnotations.Schema;
using MigrationApp.PerformanceAnalyzer.Models.Enums;

//// ReSharper disable ClassWithVirtualMembersNeverInherited.Global

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Заявка на нагрузочное тестирование.
/// </summary>
[Table("RequestBundleStorageFile")]
public class RequestBundleStorageFileEntity : EntityBase
{
    /// <summary>
    /// Групповая заявка.
    /// </summary>
    public virtual RequestBundleEntity RequestBundle { get; set; }

    /// <summary>
    /// Файл отчёта.
    /// </summary>
    public virtual StorageFileEntity StorageFile { get; set; }

    /// <summary>
    /// Тип отчёта.
    /// </summary>
    public ReportType ReportType { get; set; }

    /// <summary>
    /// Идентификатор заявки.
    /// </summary>
    [ForeignKey(nameof(RequestBundle))]
    public Guid RequestBundleId { get; set; }

    /// <summary>
    /// Идентификатор файла отчёта.
    /// </summary>
    [ForeignKey(nameof(StorageFile))]
    public Guid StorageFileId { get; set; }
}