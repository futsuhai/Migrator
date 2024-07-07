namespace MigrationApp.AnalyticsService.Models.Interfaces;

/// <summary>
/// Данные связи Результата со Значением параметра для синхронизации.
/// </summary>
public interface IAnalyticsResultParameterValueRelationModel
{
    /// <summary>
    /// Идентификатор связи Результата со Значением параметра.
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Идентификатор результата.
    /// </summary>
    Guid ResultId { get; set; }

    /// <summary>
    /// Идентификатор значения параметра.
    /// </summary>
    Guid ParameterValueId { get; set; }
}