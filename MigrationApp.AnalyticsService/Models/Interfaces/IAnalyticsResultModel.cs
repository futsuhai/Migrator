namespace MigrationApp.AnalyticsService.Models.Interfaces;

/// <summary>
/// Данные результата для синхронизации.
/// </summary>
public interface IAnalyticsResultModel
{
    /// <summary>
    /// Идентификатор результата.
    /// </summary>
    Guid Id { get; }

    /// <summary>
    /// Значение.
    /// </summary>
    double Value { get; }

    /// <summary>
    /// Идентификатор заявки.
    /// </summary>
    Guid RequestId { get; }

    /// <summary>
    /// Идентификатор показателя.
    /// </summary>
    Guid ResultParameterId { get; }
}