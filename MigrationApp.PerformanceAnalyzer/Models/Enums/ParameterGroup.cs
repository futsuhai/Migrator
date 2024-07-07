namespace MigrationApp.PerformanceAnalyzer.Models.Enums;

/// <summary>
/// Группа параметров.
/// </summary>
public enum ParameterGroup
{
    /// <summary>
    /// Группа параметров продукта.
    /// </summary>
    Product = 0,

    /// <summary>
    /// Группа параметров АО.
    /// </summary>
    HardwarePlatform = 1,

    /// <summary>
    /// Группа параметров ОС.
    /// </summary>
    OperationSystem = 2,

    /// <summary>
    /// Группа параметров методики.
    /// </summary>
    Methodology = 3,

    /// <summary>
    /// Группа параметров утилиты тестирования.
    /// </summary>
    TestingTool = 4,

    /// <summary>
    /// Группа параметров для включения/выключения подмножества тестов.
    /// </summary>
    TestSubset = 5,

    /// <summary>
    /// Группа виртуальных параметров.
    /// </summary>
    Virtual = 6,
}