using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Пункт чек-листа.
/// </summary>
[Table("CheckListStep")]
public class CheckListStepEntity : EntityBase
{
    /// <summary>
    /// Консольная команда.
    /// </summary>
    [Required]
    public string ConsoleCommand { get; set; }

    /// <summary>
    /// Описание.
    /// </summary>
    [Required]
    public string Description { get; set; }

    /// <summary>
    /// Пример вывода команды.
    /// </summary>
    public virtual StorageFileEntity ExampleImage { get; set; }

    /// <summary>
    /// Методика.
    /// </summary>
    public virtual MethodologyEntity Methodology { get; set; }

    /// <summary>
    /// Идентификатор методики.
    /// </summary>
    [ForeignKey("Methodology")]
    [Required]
    public Guid MethodologyId { get; set; }

    /// <summary>
    /// Название.
    /// </summary>
    [Required]
    public string Name { get; set; }

    /// <summary>
    /// Номер.
    /// </summary>
    [Required]
    public int Number { get; set; }

    /// <summary>
    /// Идентификатор файла с изображением.
    /// </summary>
    [ForeignKey(nameof(ExampleImage))]
    public Guid? ExampleImageId { get; set; }
}