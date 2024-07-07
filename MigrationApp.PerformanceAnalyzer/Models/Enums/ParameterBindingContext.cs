namespace MigrationApp.PerformanceAnalyzer.Models.Enums;

/// <summary>
/// Контекст привязки параметра.
/// </summary>
public enum ParameterBindingContext
{
    /// <summary>
    /// Тест.
    /// </summary>
    Test = 0,

    /// <summary>
    /// Заявка.
    /// </summary>
    Request = 1,

    /// <summary>
    /// Только стандартный.
    /// </summary>
    Standart = 2,

    ///// <summary>
    ///// Только калибровочный.
    ///// </summary>
    // [Display(Order = 3, Name = "Только калибровочный", Description = "")]
    // Calibration = 3
}