using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь продукта с файлом целевых показателей.
/// </summary>
public class ProductVersionTargetFileRelation : EntityBase
{
    /// <summary>
    /// Валидный ли файл.
    /// </summary>
    public bool IsValid { get; set; }

    /// <summary>
    /// Идентификатор версии продукта.
    /// </summary>
    [ForeignKey(nameof(ProductVersion))]
    public Guid ProductVersionId { get; set; }

    /// <summary>
    /// Идентификатор файла.
    /// </summary>
    [ForeignKey(nameof(StorageFile))]
    public Guid StorageFileId { get; set; }

    /// <summary>
    /// Файл.
    /// </summary>
    public virtual StorageFileEntity StorageFile { get; set; }

    /// <summary>
    /// Версия продукта.
    /// </summary>
    public virtual ProductVersionEntity ProductVersion { get; set; }

    /// <summary>
    /// Версия продукта.
    /// </summary>
    [ForeignKey(nameof(CreatedBy))]
    public virtual UserEntity CreatedByUser { get; set; }
}