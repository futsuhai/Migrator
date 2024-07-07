using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Дистрибутив на доске релизов OVA.
/// </summary>
[Table("OvaDistribution")]
public class OvaDistributionEntity : EntityBase
{
    /// <summary>
    /// Внешний ключ(Guid or string).
    /// </summary>
    public string ExternalId { get; set; }

    /// <summary>
    /// Имя дистрибутива.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Является ли полученным со старой длоски релизов.
    /// </summary>
    public bool IsOld { get; set; }

    /// <summary>
    /// Сериализованное значение в JSON.
    /// </summary>
    public string Data { get; set; }

    /// <summary>
    /// Продукты.
    /// </summary>
    public virtual ICollection<ProductOvaDistributionRelation> Products { get; set; }

    /// <summary>
    /// Версии дистрибутивов.
    /// </summary>
    public virtual ICollection<OvaBuildEntity> Builds { get; set; }
}