using MigrationApp.AnalyticsService.Models.Interfaces;
using MigrationApp.Common;
using MigrationApp.Common.Models;

namespace MigrationApp.AnalyticsService.Models;

/// <summary>
/// Связь результатов со значениями параметров.
/// </summary>
public class Result_ParameterValueRelationEntity : IEntity, IAnalyticsResultParameterValueRelationModel
{
    /// <inheritdoc cref="IAnalyticsResultParameterValueRelationModel.Id"/>
    public Guid Id { get; set; }

    /// <summary>
    /// Идентификатор результата.
    /// </summary>
    public Guid ResultId { get; set; }

    /// <summary>
    /// Идентификатор значения параметра.
    /// </summary>
    public Guid ParameterValueId { get; set; }
}