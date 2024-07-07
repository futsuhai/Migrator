namespace MigrationApp.PerformanceAnalyzer.Models.Enums;

/// <summary>
/// Тип отчета по заявке.
/// </summary>
public enum ReportType
{
    /// <summary>
    /// Обычный отчет.
    /// </summary>
    Regular = 0,

    /// <summary>
    /// Архитектурный отчет.
    /// </summary>
    Arch = 1,

    /// <summary>
    /// Отчет для менеджера.
    /// </summary>
    PM = 2,

    //// Не используется и в БД нет (13.06.2021).
    //// PO = 3,

    /// <summary>
    /// Ручной отчет.
    /// </summary>
    Manual = 5,
}