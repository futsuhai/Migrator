using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrationApp.Common.Models;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Entity парсеров.
/// </summary>
[Table("DataParser")]
public class DataParserEntity : IEntityBase
{
    /// <summary>
    /// Дата создания.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Автор создания.
    /// </summary>
    public Guid CreatedBy { get; set; }

    /// <summary>
    /// Идентификатор парсера.
    /// </summary>
    [Key]
    public Guid Id { get; set; }

    /// <summary>
    /// Дата последнего изменения.
    /// </summary>
    public DateTime ModifiedAt { get; set; }

    /// <summary>
    /// Автор последнего изменения.
    /// </summary>
    public Guid ModifiedBy { get; set; }

    /// <summary>
    /// Название парсера.
    /// </summary>
    public string Name { get; set; }
}