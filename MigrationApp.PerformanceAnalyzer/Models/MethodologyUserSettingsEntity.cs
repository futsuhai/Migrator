using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Настройки методики пользователя.
/// </summary>
[Table("Methodology_UserSettings")]
public class MethodologyUserSettingsEntity : EntityBase
{
    /// <summary>
    /// Пользователь.
    /// </summary>
    public virtual UserEntity User { get; set; }

    /// <summary>
    /// Методика.
    /// </summary>
    public virtual MethodologyEntity Methodology { get; set; }

    /// <summary>
    /// Подписан ли на глобальные оповещения.
    /// </summary>
    public bool IsSubscribed { get; set; }

    /// <summary>
    /// Является ли пользователь администратором.
    /// </summary>
    public bool IsUserMethodologyAdmin { get; set; }

    /// <summary>
    /// Является ли пользователь (если он тестировщик) аккредитованным по данной методике.
    /// </summary>
    public bool IsCompetent { get; set; }

    /// <summary>
    /// Идентификатор пользователя.
    /// </summary>
    [ForeignKey("User")]
    public Guid UserId { get; set; }

    /// <summary>
    /// Идентификатор методики.
    /// </summary>
    [ForeignKey("Methodology")]
    public Guid MethodologyId { get; set; }
}