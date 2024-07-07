using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using MigrationApp.PerformanceAnalyzer.Models.Enums;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Параметр.
/// </summary>
[Table("Parameter")]
public class ParameterEntity : EntityBase
{
    /// <summary>
    /// Тип данных параметра.
    /// </summary>
    [Column("DataTypeId")]
    public ParameterDataType DataType { get; set; }

    /// <summary>
    /// Название параметра.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Короткое название параметра (для GUI).
    /// </summary>
    public string ShortName { get; set; }

    /// <summary>
    /// Код параметра (для конфигов).
    /// </summary>
    public string ParameterCode { get; set; }

    /// <summary>
    /// Группа параметров, к которой относится данный.
    /// </summary>
    [Column("ParameterGroupId")]
    public ParameterGroup ParameterGroup { get; set; }

    /// <summary>
    /// Пояснение.
    /// </summary>
    public string Note { get; set; }

    /// <summary>
    /// Является ли ключевым.
    /// </summary>
    public bool IsCrucial { get; set; }

    /// <summary>
    /// Регулярное выражение для валидации значений.
    /// </summary>
    public string ValueValidationRule { get; set; }

    /// <summary>
    /// Переводы для параметров.
    /// </summary>
    public virtual ICollection<ParameterTranslationEntity> Translations { get; set; }

    /// <summary>
    /// Значения параметра.
    /// </summary>
    [JsonIgnore]
    public virtual ICollection<ParameterValueEntity> Values { get; set; }

    /// <summary>
    /// Связи параметра с методиками.
    /// </summary>
    public virtual ICollection<MethodologyParameterRelation> Methodologies { get; set; }
}