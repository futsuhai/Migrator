using MigrationApp.AnalyticsService.Models.Interfaces;
using MigrationApp.Common;
using MigrationApp.Common.Models;

namespace MigrationApp.AnalyticsService.Models;

/// <summary>
/// Данные о значениях параметров.
/// </summary>
public class ParameterValueEntity : IEntity, IAnalyticsParameterValueModel
{
    /// <inheritdoc cref="IAnalyticsParameterValueModel.Id"/>
    public Guid Id { get; set; }

    /// <summary>
    /// Значение.
    /// </summary>
    public string Value { get; set; }

    /// <summary>
    /// Идентификатор параметра.
    /// </summary>
    public Guid ParameterId { get; set; }

    /// <summary>
    /// Результаты, в которых есть параметр.
    /// </summary>
    public virtual ICollection<Result_ParameterValueRelationEntity> Results { get; set; }
}