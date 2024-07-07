namespace MigrationApp.PerformanceAnalyzer.Models.Enums;

/// <summary>
/// Тип действия над оборудованием.
/// </summary>
public enum EquipmentActionType
{
    /// <summary>
    /// Зарезервировано по заявке.
    /// </summary>
    Request = 0,

    /// <summary>
    /// Временно недоступно.
    /// </summary>
    TemporarilyUnavailable = 1,

    /// <summary>
    /// Резерв эксперта.
    /// </summary>
    ExpertReserve = 2,

    /// <summary>
    /// Зарезервировано по заявке (сборная колбаска).
    /// </summary>
    CombinedRequest = 3,
}