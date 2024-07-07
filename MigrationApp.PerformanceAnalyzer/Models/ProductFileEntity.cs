using System.ComponentModel.DataAnnotations.Schema;
using MigrationApp.PerformanceAnalyzer.Models.Enums;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Entity файла продукта.
/// </summary>
[Table("ProductFile")]
public class ProductFileEntity : EntityBase
{
    /// <summary>
    /// Дата добавления файла продукта.
    /// </summary>
    public DateTime CreationDate { get; set; }

    /// <summary>
    /// Описание файла.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Продукт, к которой относится файл.
    /// </summary>
    public virtual ProductEntity Product { get; set; }

    /// <summary>
    /// Идентификатор продукта.
    /// </summary>
    [ForeignKey("Product")]
    public Guid ProductId { get; set; }

    /// <summary>
    /// Файл собственной персоной.
    /// </summary>
    public virtual StorageFileEntity StorageFile { get; set; }

    /// <summary>
    /// Идентификатор файла в хранилище.
    /// </summary>
    [ForeignKey("StorageFile")]
    public Guid StorageFileId { get; set; }

    /// <summary>
    /// Тип файла.
    /// </summary>
    public ProductFileType Type { get; set; }
}