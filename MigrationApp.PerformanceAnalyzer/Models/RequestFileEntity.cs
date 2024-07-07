using System.ComponentModel.DataAnnotations.Schema;
using MigrationApp.PerformanceAnalyzer.Models.Enums;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Файл, связанный с заявкой.
/// </summary>
[Table("RequestFile")]
public class RequestFileEntity : EntityBase
{
    /// <summary>
    /// Тип файла.
    /// </summary>
    public RequestFileType FileType { get; set; }

    /// <summary>
    /// Заявка на тестирование.
    /// </summary>
    public virtual RequestEntity Request { get; set; }

    /// <summary>
    /// Файл собственной персоной.
    /// </summary>
    public virtual StorageFileEntity StorageFile { get; set; }

    /// <summary>
    /// Идентификатор файла в хранилище.
    /// </summary>
    [ForeignKey(nameof(StorageFile))]
    public Guid StorageFileId { get; set; }

    /// <summary>
    /// Идентификатор заявки.
    /// </summary>
    [ForeignKey(nameof(Request))]
    public Guid RequestId { get; set; }

    /// <summary>
    /// Результаты по заявке.
    /// </summary>
    public virtual ICollection<RequestResultDataEntity> RequestResultDataEntities { get; set; }
}