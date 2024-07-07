namespace MigrationApp.PerformanceAnalyzer.Models.Enums;

/// <summary>
/// Принадлежность оборудования.
/// </summary>
public enum EquipmentOwn
{
    /// <summary>
    /// Отдел исследования производительности.
    /// </summary>
    LoadRunner = 0,

    /// <summary>
    /// ЗАО "Перспективный мониторинг".
    /// </summary>
    ProspectiveMonitoring = 1,

    /// <summary>
    /// Другое.
    /// </summary>
    Custom = 2,

    /// <summary>
    /// ДППП: Отдел развития продуктов.
    /// </summary>
    DPPP = 3,

    /// <summary>
    /// ОККП Уфа.
    /// </summary>
    OkppUfa = 4,

    /// <summary>
    /// Томск.
    /// </summary>
    Tomsk = 5,

    /// <summary>
    /// Санкт-Петербург.
    /// </summary>
    SaintPetersburg = 6,

    /// <summary>
    /// Sies.
    /// </summary>
    Sies = 7,

    /// <summary>
    /// Berlin.
    /// </summary>
    Berlin = 8,
}