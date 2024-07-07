using System.ComponentModel.DataAnnotations.Schema;
using MigrationApp.PerformanceAnalyzer.Models.Enums;

//// ReSharper disable ClassWithVirtualMembersNeverInherited.Global

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Заявка на нагрузочное тестирование.
/// </summary>
[Table("RequestReportFile")]
public class RequestReportFileEntity : EntityBase
{
    /// <summary>
    /// Заявка.
    /// </summary>
    public virtual RequestEntity Request { get; set; }

    /// <summary>
    /// Файл отчёта.
    /// </summary>
    public virtual StorageFileEntity StorageFile { get; set; }

    /// <summary>
    /// Тип отчёта.
    /// </summary>
    public ReportType ReportType { get; set; }

    /// <summary>
    /// Язык.
    /// </summary>
    public string Language { get; set; }

    /// <summary>
    /// Идентификатор заявки.
    /// </summary>
    [ForeignKey(nameof(Request))]
    public Guid RequestId { get; set; }

    /// <summary>
    /// Идентификатор файла отчёта.
    /// </summary>
    [ForeignKey(nameof(StorageFile))]
    public Guid StorageFileId { get; set; }
}