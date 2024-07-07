namespace MigrationApp.PerformanceAnalyzer.Models.Enums;

/// <summary>
/// Статус ревью заявки.
/// </summary>
public enum RequestReviewStatus
{
    /// <summary>
    /// Не проводилось.
    /// </summary>
    NoReview = 0,

    /// <summary>
    /// Пройдено успешно.
    /// </summary>
    Passed = 1,

    /// <summary>
    /// Заявка зафейлена.
    /// </summary>
    Failed = 2,
}