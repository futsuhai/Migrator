namespace MigrationApp.PerformanceAnalyzer.Models.Enums;

/// <summary>
/// Статус методики.
/// </summary>
[Flags]
public enum MethodologyStatusFlag
{
    /// <summary>
    /// Пустое значение.
    /// </summary>
    None = 0,

    /// <summary>
    /// В разработке.
    /// </summary>
    InDevelopment = 1,

    /// <summary>
    /// Внедрена (ручная генерация отчёта).
    /// </summary>
    InUseManual = 1 << 1,

    /// <summary>
    /// Внедрена (автоматическая генерация отчёта).
    /// </summary>
    InUseAuto = 1 << 2,

    /// <summary>
    /// Запланирована.
    /// </summary>
    IsScheduled = 1 << 3,

    /// <summary>
    /// Заблокирована. Нельзя создавать заявки.
    /// </summary>
    Blocked = 1 << 4,
}