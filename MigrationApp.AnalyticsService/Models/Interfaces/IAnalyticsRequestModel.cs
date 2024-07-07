using MigrationApp.AnalyticsService.Models.Enums;

namespace MigrationApp.AnalyticsService.Models.Interfaces;

/// <summary>
/// Данные заявки для синхронизации.
/// </summary>
public interface IAnalyticsRequestModel
{
    /// <summary>
    /// Идентификатор заявки.
    /// </summary>
    Guid Id { get; }

    /// <summary>
    /// Номер заявки.
    /// </summary>
    int Number { get; }

    /// <summary>
    /// Версия продукта.
    /// </summary>
    string ProductVersion { get; }

    /// <summary>
    /// Идентификатор продукта.
    /// </summary>
    Guid ProductId { get; }

    /// <summary>
    /// Идентификатор группы продукта.
    /// </summary>
    Guid ProductGroupId { get; }

    /// <summary>
    /// Идентификатор методики.
    /// </summary>
    Guid MethodologyId { get; }

    /// <summary>
    /// Номер сборки в сыром виде.
    /// </summary>
    string Build { get; }

    /// <summary>
    /// Номер сборки в числовом виде.
    /// </summary>
    int? BuildNumber { get; }

    /// <summary>
    /// Тип сборки.
    /// </summary>
    BuildTypeFlag BuildType { get; }

    /// <summary>
    /// Идентификатор аппаратной платформы.
    /// </summary>
    Guid HardwarePlatformId { get; }

    /// <summary>
    /// Идентификатор виртуальной платформы.
    /// </summary>
    Guid? VirtualPlatformId { get; }

    /// <summary>
    /// Дата окончания тестирования (перевода заявки из статуса "Идет тестирование").
    /// </summary>
    DateTime TestingDate { get; }
}