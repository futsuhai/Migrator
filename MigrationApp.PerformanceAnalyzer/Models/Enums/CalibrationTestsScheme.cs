namespace MigrationApp.PerformanceAnalyzer.Models.Enums;

/// <summary>
/// Требования к калибровочным тестам.
/// </summary>
public enum CalibrationTestsScheme
{
    /// <summary>
    /// Поведение не определено.
    /// </summary>
    Undefined = 0,

    /// <summary>
    /// Калибровочный тест не требуется.
    /// </summary>
    NoCalibration = 1,

    /// <summary>
    /// Требуется один калибровочный тест.
    /// </summary>
    OneCalibration = 2,

    /// <summary>
    /// Возможно несколько калибровочных тестов (1.. N).
    /// </summary>
    ManyCalibration = 3,

    /// <summary>
    /// Выбор калибровочных тестов заказчиком.
    /// </summary>
    CustomerAdjustedCalibration = 4,

    /// <summary>
    /// Калибровочный тест генерируется автоматически.
    /// </summary>
    AutoCalibration = 5,

    /// <summary>
    /// Возможно несколько калибровочных тестов (0.. N).
    /// </summary>
    SeveralCalibration = 6,
}