using MigrationApp.AnalyticsService.Models.Enums;
using MigrationApp.AnalyticsService.Models.Interfaces;
using MigrationApp.Common;
using MigrationApp.Common.Models;

namespace MigrationApp.AnalyticsService.Models;

/// <summary>
/// Результат тестирования.
/// </summary>
public class ResultEntity : IEntity, IAnalyticsResultModel
{
    /// <inheritdoc cref="IAnalyticsResultModel.Id"/>
    public Guid Id { get; set; }

    /// <summary>
    /// Значение.
    /// </summary>
    public double Value { get; set; }

    /// <summary>
    /// Идентификатор заявки.
    /// </summary>
    public Guid RequestId { get; set; }

    /// <summary>
    /// Идентификатор показателя.
    /// </summary>
    public Guid ResultParameterId { get; set; }

    /// <summary>
    /// Идентификатор целевого значения.
    /// </summary>
    public Guid? TargetId { get; set; }

    /// <summary>
    /// Качество результата.
    /// </summary>
    public ResultParameterValueQuality? Quality { get; set; }

    /// <summary>
    /// Идентификатор конфигурации.
    /// </summary>
    public Guid? ConfigurationId { get; set; }

    /// <summary>
    /// Заявка.
    /// </summary>
    public virtual RequestEntity Request { get; set; }

    /// <summary>
    /// Целевое значение.
    /// </summary>
    public virtual TargetEntity Target { get; set; }

    /// <summary>
    /// Значения параметров.
    /// </summary>
    public virtual ICollection<Result_ParameterValueRelationEntity> ParameterValues { get; set; }
}