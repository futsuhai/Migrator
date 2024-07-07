namespace MigrationApp.SearchService.Models.Enums;

/// <summary>
/// Статус методики.
/// </summary>
public enum MethodologyStatus
{
    /// <summary>
    /// В разработке.
    /// </summary>
    InDevelopment = 0,

    /// <summary>
    /// Внедрена (ручная генерация отчёта).
    /// </summary>
    InUseManual = 1,

    /// <summary>
    /// Внедрена (автоматическая генерация отчёта).
    /// </summary>
    InUseAuto = 2,

    /// <summary>
    /// Запланирована.
    /// </summary>
    IsScheduled = 3,

    /// <summary>
    /// Заблокирована. Нельзя создавать заявки.
    /// </summary>
    Blocked = 4,
}