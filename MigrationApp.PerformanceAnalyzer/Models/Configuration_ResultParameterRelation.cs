using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь конфигурации и значения параметра.
/// </summary>
[Table("Configuration_ResultParameterRelation")]
public class Configuration_ResultParameterRelation : EntityBase
{
    /// <summary>
    /// Идентификатор показателя.
    /// </summary>
    [ForeignKey(nameof(ResultParameter))]
    public Guid ResultParameterId { get; set; }

    /// <summary>
    /// Показатель.
    /// </summary>
    public virtual ResultParameterEntity ResultParameter { get; set; }

    /// <summary>
    /// Идентификатор конфигурации.
    /// </summary>
    [ForeignKey(nameof(Configuration))]
    public Guid ConfigurationId { get; set; }

    /// <summary>
    /// Конфигурация.
    /// </summary>
    public virtual ConfigurationEntity Configuration { get; set; }

    /// <summary>
    /// Идентификатор конфигурации.
    /// </summary>
    [ForeignKey(nameof(TargetRow))]
    public Guid? TargetRowId { get; set; }

    /// <summary>
    /// Конфигурация.
    /// </summary>
    public virtual TargetRowEntity TargetRow { get; set; }

    /// <summary>
    /// Идентификатор группы продуктов.
    /// </summary>
    [ForeignKey(nameof(ProductGroup))]
    public Guid? ProductGroupId { get; set; }

    /// <summary>
    /// Группа продуктов.
    /// </summary>
    public virtual ProductGroupEntity ProductGroup { get; set; }

    /// <summary>
    /// Версия проодуктов.
    /// </summary>
    public string ProductVersionName { get; set; }

    /// <summary>
    /// Связанные цели.
    /// </summary>
    public virtual ICollection<TargetNewEntity> Targets { get; set; }

    /// <summary>
    /// Псевдонимы.
    /// </summary>
    public virtual ICollection<ConfigurationAliasEntity> Aliases { get; set; }

    /// <summary>
    /// Автор изменения.
    /// </summary>
    [ForeignKey(nameof(ModifiedBy))]
    public virtual UserEntity ModifiedByUser { get; set; }
}