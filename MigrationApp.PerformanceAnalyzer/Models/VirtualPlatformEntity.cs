using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Виртуальное исполнение.
/// </summary>
public class VirtualPlatformEntity : EntityBase
{
    /// <summary>
    /// Название.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Идентификатор продукта.
    /// </summary>
    [ForeignKey(nameof(Product))]
    public Guid ProductId { get; set; }

    /// <summary>
    /// Продукт.
    /// </summary>
    public virtual ProductEntity Product { get; set; }

    /// <summary>
    /// привязанные параметры.
    /// </summary>
    public virtual ICollection<VirtualPlatformParameterValueRelation> ParameterValues { get; set; }
}