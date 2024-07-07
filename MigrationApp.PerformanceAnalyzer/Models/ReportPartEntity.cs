using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Блок отчета.
/// </summary>
public class ReportPartEntity : EntityBase
{
    /// <summary>
    /// Имя.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Пусть к Frx (относительно папки 'Templates').
    /// </summary>
    public string FrxPath { get; set; }

    /// <summary>
    /// Является ли общеиспользуемым.
    /// </summary>
    public bool IsCommon { get; set; }

    /// <summary>
    /// Описание.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Скриншот с примером заполненного блока.
    /// </summary>
    public virtual StorageFileEntity Image { get; set; }

    /// <summary>
    /// Список связей с методиками.
    /// </summary>
    public virtual ICollection<Methodology_ReportPartRelation> Methodologies { get; set; }

    /// <summary>
    /// Скриншот с примером заполненного блока.
    /// </summary>
    [ForeignKey(nameof(Image))]
    public Guid? ImageId { get; set; }
}