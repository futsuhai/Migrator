namespace MigrationApp.PerformanceAnalyzer.Models.Enums;

/// <summary>
/// Описание группировки параметров в отчете по методике.
/// </summary>
public enum ParameterGroupType
{
    /// <summary>
    /// Неопределено.
    /// </summary>
    Undefined = 0,

    /// <summary>
    /// Плоский.
    /// </summary>
    Plain = 1,

    /// <summary>
    /// Группировка по тестам.
    /// </summary>
    ByTest = 2,

    /// <summary>
    /// Ручная группировка.
    /// </summary>
    Custom = 3,

    /// <summary>
    /// Граппировка вручную и по тестам.
    /// </summary>
    /// <remarks>
    /// Параметры, добавленные в группы, извлекаются из всех тестов в отдельный раздел.
    /// Несгруппированные параметры группируются по параметрам заявки/тестов.
    /// </remarks>
    TestAndCustom = 4,
}