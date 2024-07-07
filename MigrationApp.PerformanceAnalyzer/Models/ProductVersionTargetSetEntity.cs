using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Набор целевой показателей для номера версии продуктов.
/// </summary>
[Table("ProductVersionTargetSet")]
public class ProductVersionTargetSetEntity : EntityBase
{
    /// <summary>
    /// Идентификтаор файла в хранилище.
    /// </summary>
    public virtual StorageFileEntity StorageFile { get; set; }

    /// <summary>
    /// Номер версий продуктов.
    /// </summary>
    [StringLength(40)]
    public string ProductVersionName { get; set; }

    /// <summary>
    /// Дата загрузки.
    /// </summary>
    public DateTime DateLoaded { get; set; }

    /// <summary>
    /// Идентификтаор файла в хранилище.
    /// </summary>
    [ForeignKey(nameof(StorageFile))]
    public Guid? StorageFileId { get; set; }
}