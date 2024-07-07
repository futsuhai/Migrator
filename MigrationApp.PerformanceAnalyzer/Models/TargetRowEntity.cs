using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Строка справочника целевых значений.
/// </summary>
[Table("TargetRow")]
public class TargetRowEntity : EntityBase
{
    /// <summary>
    /// Наименование.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Идентификатор показателя.
    /// </summary>
    [ForeignKey(nameof(ResultParameter))]
    public Guid ResultParameterId { get; set; }

    /// <summary>
    /// Идентификатор группы продуктов.
    /// </summary>
    [ForeignKey(nameof(ProductGroup))]
    public Guid? ProductGroupId { get; set; }

    /// <summary>
    /// Версия проодуктов.
    /// </summary>
    public string ProductVersionName { get; set; }

    /// <summary>
    /// Порядковый номер строки.
    /// </summary>
    public int Order { get; set; }

    /// <summary>
    /// Группа продуктов.
    /// </summary>
    public virtual ProductGroupEntity ProductGroup { get; set; }

    /// <summary>
    /// Показатель.
    /// </summary>
    public virtual ResultParameterEntity ResultParameter { get; set; }

    /// <summary>
    /// Ячейки справочника.
    /// </summary>
    public virtual ICollection<Configuration_ResultParameterRelation> ResultParameterRelations { get; set; }
}