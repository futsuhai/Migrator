using System.ComponentModel;

namespace MigrationApp.AnalyticsService.Models.Enums;

/// <summary>
/// Качество результата в зависимости от эталонного значения показателя.
/// </summary>
public enum ResultParameterValueQuality
{
    /// <summary>
    /// Результат не имеет эталонного значения.
    /// </summary>
    [Description("n/a")]
    NotSpecified,

    /// <summary>
    /// Результат входит в эталонный диапазон.
    /// </summary>
    [Description("normal")]
    Normal,

    /// <summary>
    /// Результат лучше эталонного.
    /// </summary>
    [Description("good")]
    Good,

    /// <summary>
    /// Результат хуже эталонного.
    /// </summary>
    [Description("poor")]
    Poor,
}