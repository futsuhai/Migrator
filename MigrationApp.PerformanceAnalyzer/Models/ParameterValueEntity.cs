using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using MigrationApp.PerformanceAnalyzer.Models.Enums;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Значение параметра.
/// </summary>
[Table("ParameterValue")]
public class ParameterValueEntity : EntityBase
{
    /// <summary>
    /// Порядковый номер значения в списке значений параметра.
    /// </summary>
    public int? OrderIndex { get; set; }

    /// <summary>
    /// Параметр.
    /// </summary>
    [JsonIgnore]
    public virtual ParameterEntity Parameter { get; set; }

    /// <summary>
    /// Состояние видимости значения (имеются триггеры/скрывающие параметры).
    /// </summary>
    public ParameterValueVisibility Visibility { get; set; }

    /// <summary>
    /// Связи с другими значениями параметров, влияющие на видимость.
    /// </summary>
    [JsonIgnore]
    [InverseProperty(nameof(ParameterShadowedValueEntity.ShadowedParameterValue))]
    public virtual ICollection<ParameterShadowedValueEntity> VisibilityRelations { get; set; } =
        new List<ParameterShadowedValueEntity>();

    /// <summary>
    /// Переводы для значения параметра.
    /// </summary>
    public virtual ICollection<ParameterValueTranslationEntity> Translations { get; set; } =
        new List<ParameterValueTranslationEntity>();

    /// <summary>
    /// Идентификатор параметра.
    /// </summary>
    [ForeignKey("Parameter")]
    public Guid ParameterId { get; set; }

    /// <summary>
    /// Значение параметра в строковом виде.
    /// </summary>
    public string Value { get; set; }

    /// <summary>
    /// Связи параметра с версиями продуктов.
    /// </summary>
    public virtual ICollection<ProductVersionParameterValueRelation> ProductVersions { get; set; }

    /// <summary>
    /// Связи параметра с операционными системами.
    /// </summary>
    public virtual ICollection<OperationSystemParameterValueRelation> OperationSystems { get; set; }

    /// <summary>
    /// Связи параметра с аппаратными платформами.
    /// </summary>
    public virtual ICollection<HardwarePlatformParameterValueRelation> HardwarePlatforms { get; set; }
}