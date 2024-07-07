namespace MigrationApp.PerformanceAnalyzer.Models.Enums;

/// <summary>
/// Причина временной недоступности оборудования.
/// </summary>
public enum EquipmentTemporarilyUnavailableReason
{
    /// <summary>
    /// Поломано.
    /// </summary>
    Broken = 0,

    /// <summary>
    /// Срочная заявка.
    /// </summary>
    UrgentRequest = 1,

    /// <summary>
    /// Инвентаризация.
    /// </summary>
    Inventory = 2,

    /// <summary>
    /// Другое.
    /// </summary>
    OtherReason = 3,
}