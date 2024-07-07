using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrationApp.Common.Models;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
///     Алгоритм расчёта теоретического максимума.
/// </summary>
[Table("TheoreticalMaximumAlgorithm")]
public class TheoreticalMaximumAlgorithmEntity : IEntityBase
{
    /// <summary>
    ///     Идентификатор.
    /// </summary>
    [Key]
    public Guid Id { get; set; }

    /// <summary>
    /// Дата создания.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Дата последнего изменения.
    /// </summary>
    public DateTime ModifiedAt { get; set; }

    /// <summary>
    /// Автор последнего изменения.
    /// </summary>
    public Guid ModifiedBy { get; set; }

    /// <summary>
    /// Автор создания.
    /// </summary>
    public Guid CreatedBy { get; set; }

    /// <summary>
    ///     Название.
    /// </summary>
    public string Name { get; set; }
}