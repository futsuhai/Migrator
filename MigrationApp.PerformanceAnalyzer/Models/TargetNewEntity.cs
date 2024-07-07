using System.ComponentModel.DataAnnotations.Schema;
using MigrationApp.PerformanceAnalyzer.Models.Enums;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Цель.
/// TODO: Rename to Target.
/// </summary>
[Table("TargetNew")]
public class TargetNewEntity : EntityBase
{
    /// <summary>
    /// Источник цели.
    /// </summary>
    public TargetSource Source { get; set; }

    /// <summary>
    /// Максимум.
    /// </summary>
    public double? MaxValue { get; set; }

    /// <summary>
    /// Минимум.
    /// </summary>
    public double? MinValue { get; set; }

    /// <summary>
    /// Максимум.
    /// </summary>
    public double? MaxTarget { get; set; }

    /// <summary>
    /// Минимум.
    /// </summary>
    public double? MinTarget { get; set; }

    /// <summary>
    /// Максимум.
    /// </summary>
    public double? MaxDeviation { get; set; }

    /// <summary>
    /// Минимум.
    /// </summary>
    public double? MinDeviation { get; set; }

    /// <summary>
    /// Идентификатор версии продукта.
    /// </summary>
    [ForeignKey(nameof(ProductVersion))]
    public Guid ProductVersionId { get; set; }

    /// <summary>
    /// Идентификатор фичсета.
    /// </summary>
    [ForeignKey(nameof(FeatureSet))]
    public Guid? FeatureSetId { get; set; }

    /// <summary>
    /// Идентификатор связи конфигурации и значения параметра.
    /// </summary>
    [ForeignKey(nameof(Configuration_ResultParameterRelation))]
    public Guid Configuration_ResultParameterRelationId { get; set; }

    /// <summary>
    /// Идентификатор файла в хранилище.
    /// </summary>
    [ForeignKey(nameof(StorageFile))]
    public Guid? StorageFileId { get; set; }

    /// <summary>
    /// Идентификатор Создателя.
    /// </summary>
    [ForeignKey(nameof(CreatedByEntity))]
    public new Guid CreatedBy { get; set; }

    /// <summary>
    /// Версия продукта.
    /// </summary>
    public virtual ProductVersionEntity ProductVersion { get; set; }

    /// <summary>
    /// Фичсет.
    /// </summary>
    public virtual FeatureSetEntity FeatureSet { get; set; }

    /// <summary>
    /// Связь конфигурации и значения параметра.
    /// </summary>
    public virtual Configuration_ResultParameterRelation Configuration_ResultParameterRelation { get; set; }

    /// <summary>
    /// Файл в хранилище.
    /// </summary>
    public virtual StorageFileEntity StorageFile { get; set; }

    /// <summary>
    /// Сущность пользователя, создавшего цель.
    /// </summary>
    public virtual UserEntity CreatedByEntity { get; set; }

    /// <summary>
    /// Автор изменения.
    /// </summary>
    [ForeignKey(nameof(ModifiedBy))]
    public virtual UserEntity ModifiedByUser { get; set; }
}