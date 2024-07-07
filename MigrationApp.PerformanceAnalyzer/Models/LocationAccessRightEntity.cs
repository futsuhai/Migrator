using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Доступ к локации.
/// </summary>
[Table("LocationAccessRight")]
public class LocationAccessRightEntity : EntityBase
{
    /// <summary>
    /// Пользователь (тестировщик).
    /// </summary>
    public virtual UserEntity User { get; set; }

    /// <summary>
    /// Пользователь.
    /// </summary>
    [ForeignKey("User")]
    public Guid UserId { get; set; }

    /// <summary>
    /// Локация.
    /// </summary>
    public virtual LocationEntity Location { get; set; }

    /// <summary>
    /// Идентификатор локации.
    /// </summary>
    [ForeignKey("Location")]
    public Guid LocationId { get; set; }
}