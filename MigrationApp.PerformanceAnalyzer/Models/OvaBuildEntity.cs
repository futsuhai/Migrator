using System.ComponentModel.DataAnnotations.Schema;
using MigrationApp.PerformanceAnalyzer.Models.Enums;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Информация о билде на сервисе release.
/// </summary>
[Table("OvaBuild")]
public class OvaBuildEntity : EntityBase
{
    /// <summary>
    /// Внешний ключ(Guid or string).
    /// </summary>
    public string ExternalId { get; set; }

    /// <summary>
    /// Номер сборки.
    /// </summary>
    public int Number { get; set; }

    /// <summary>
    /// Является ли полученным со старой доски релизов.
    /// </summary>
    public bool IsOld { get; set; }

    /// <summary>
    /// Время билда.
    /// </summary>
    public DateTime BuildTime { get; set; }

    /// <summary>
    /// Версия.
    /// </summary>
    public string Version { get; set; }

    /// <summary>
    /// Идентификатор сборки.
    /// </summary>
    [ForeignKey(nameof(Build))]
    public Guid BuildId { get; set; }

    /// <summary>
    /// Сборка.
    /// </summary>
    public virtual BuildEntity Build { get; set; }

    /// <summary>
    /// Состояние жизненного цикла сборки.
    /// </summary>
    public LifeCycleState LifeCycleState { get; set; }

    /// <summary>
    /// Внешний ключ к версии продукта(поставляемый доской релизов).
    /// </summary>
    [ForeignKey(nameof(OvaDistribution))]
    public Guid? OvaDistributionId { get; set; }

    /// <summary>
    /// Версия продукта.
    /// </summary>
    public virtual OvaDistributionEntity OvaDistribution { get; set; }

    /// <summary>
    /// Сериализованное значение в JSON.
    /// </summary>
    public string Data { get; set; }

    /// <summary>
    /// Протестирована ли сборка на VPA.
    /// </summary>
    public bool TestedOnVpa { get; set; }
}