using MigrationApp.AnalyticsService.Models.Enums;
using MigrationApp.AnalyticsService.Models.Interfaces;
using MigrationApp.Common;
using MigrationApp.Common.Models;

namespace MigrationApp.AnalyticsService.Models;

/// <summary>
/// Заявка.
/// </summary>
public class RequestEntity : IEntity, IAnalyticsRequestModel
{
    /// <inheritdoc cref="IAnalyticsRequestModel.Id" />
    public Guid Id { get; set; }

    /// <summary>
    /// Номер заявки.
    /// </summary>
    public int Number { get; set; }

    /// <summary>
    /// Версия продукта.
    /// </summary>
    public string ProductVersion { get; set; }

    /// <summary>
    /// Идентификатор продукта.
    /// </summary>
    public Guid ProductId { get; set; }

    /// <summary>
    /// Идентификатор группы продукта.
    /// </summary>
    public Guid ProductGroupId { get; set; }

    /// <summary>
    /// Идентификатор методики.
    /// </summary>
    public Guid MethodologyId { get; set; }

    /// <summary>
    /// Номер сборки в сыром виде.
    /// </summary>
    public string? Build { get; set; }

    /// <summary>
    /// Номер сборки в числовом виде.
    /// </summary>
    public int? BuildNumber { get; set; }

    /// <summary>
    /// Тип сборки.
    /// </summary>
    public BuildTypeFlag BuildType { get; set; }

    /// <summary>
    /// Идентификатор аппаратной платформы.
    /// </summary>
    public Guid HardwarePlatformId { get; set; }

    /// <summary>
    /// Идентификатор виртуальной платформы.
    /// </summary>
    public Guid? VirtualPlatformId { get; set; }

    /// <summary>
    /// Дата окончания тестирования (перевода заявки из статуса "Идет тестирование").
    /// </summary>
    public DateTime TestingDate { get; set; }

    /// <summary>
    /// Результаты.
    /// </summary>
    public virtual ICollection<ResultEntity> Results { get; set; }
}