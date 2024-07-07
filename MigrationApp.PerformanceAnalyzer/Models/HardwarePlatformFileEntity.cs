using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Entity файла аппаратной платформы.
/// </summary>
[Table("HardwarePlatformFile")]
public class HardwarePlatformFileEntity : EntityBase
{
    /// <summary>
    /// Аппаратная платформа, к которой относится файл.
    /// </summary>
    public virtual HardwarePlatformEntity HardwarePlatform { get; set; }

    /// <summary>
    /// Файл собственной персоной.
    /// </summary>
    public virtual StorageFileEntity StorageFile { get; set; }

    /// <summary>
    /// Идентификатор продукта.
    /// </summary>
    [ForeignKey(nameof(HardwarePlatform))]
    public Guid HardwarePlatformId { get; set; }

    /// <summary>
    /// Идентификатор файла в хранилище.
    /// </summary>
    [ForeignKey(nameof(StorageFile))]
    public Guid StorageFileId { get; set; }
}