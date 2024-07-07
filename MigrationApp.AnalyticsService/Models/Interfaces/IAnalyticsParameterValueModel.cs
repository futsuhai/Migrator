namespace MigrationApp.AnalyticsService.Models.Interfaces;

public interface IAnalyticsParameterValueModel
{
    /// <summary>
    /// Идентификатор значения параметра.
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Значение.
    /// </summary>
    string Value { get; set; }

    /// <summary>
    /// Идентификатор параметра.
    /// </summary>
    Guid ParameterId { get; set; }
}