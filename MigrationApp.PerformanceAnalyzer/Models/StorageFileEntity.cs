using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Файл хранилища.
/// </summary>
[Table("StorageFile")]
public class StorageFileEntity : EntityBase
{
    /// <summary>
    /// Название файла.
    /// </summary>
    public string FileName { get; set; }

    /// <summary>
    /// Размер файла.
    /// </summary>
    public long FileSize { get; set; }

    /// <summary>
    /// Хэш файла.
    /// </summary>
    public string Hash { get; set; }

    /// <summary>
    /// Номер файла.
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Number { get; set; }

    /// <summary>
    /// Уже загружено?!!.
    /// </summary>
    public bool Uploaded { get; set; }
}