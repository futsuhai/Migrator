using System.ComponentModel.DataAnnotations.Schema;
using MigrationApp.PerformanceAnalyzer.Models.Enums;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь методики и параметра.
/// </summary>
[Table("Methodology_ParameterRelation")]
public class MethodologyParameterRelation : EntityBase
{
    /// <summary>
    /// Контекст связки.
    /// </summary>
    public ParameterBindingContext BindingContext { get; set; }

    /// <summary>
    /// Обязателен для заполнения.
    /// </summary>
    public bool IsRequired { get; set; }

    /// <summary>
    /// Тип итератора.
    /// </summary>
    public ParameterIteratorType IteratorType { get; set; }

    /// <summary>
    /// Методика тестирования.
    /// </summary>
    public virtual MethodologyEntity Methodology { get; set; }

    /// <summary>
    /// Идентификатор методики.
    /// </summary>
    [ForeignKey("Methodology")]
    public Guid MethodologyId { get; set; }

    /// <summary>
    /// Группа параметров методики.
    /// </summary>
    public virtual MethodologyParametersGroup MethodologyParametersGroup { get; set; }

    /// <summary>
    /// Идентификатор группы параметров методики.
    /// </summary>
    [ForeignKey("MethodologyParametersGroup")]
    public Guid? MethodologyParametersGroupId { get; set; }

    /// <summary>
    /// Порядковый номер.
    /// </summary>
    public int OrderNumber { get; set; }

    /// <summary>
    /// Параметр.
    /// </summary>
    public virtual ParameterEntity Parameter { get; set; }

    /// <summary>
    /// Идентификатор параметра.
    /// </summary>
    [ForeignKey("Parameter")]
    public Guid ParameterId { get; set; }

    /// <summary>
    /// Тип отображения параметра.
    /// </summary>
    [Column("ParameterViewTypeId")]
    public ParameterViewType ViewType { get; set; }

    /// <summary>
    /// Список возможных значений параметра.
    /// </summary>
    public virtual ICollection<MethodologyParameterValueRelationEntity> ParameterValueRelations { get; set; }

    /// <summary>
    /// Триггеры видимости параметра.
    /// </summary>
    public virtual ICollection<MethodologyParameterTriggerEntity> Triggers { get; set; }

    /// <summary>
    /// Триггеры видимости параметра от продукта.
    /// </summary>
    public virtual ICollection<MethodologyParameterProductVisibilityRelation> ProductTriggers { get; set; }

    /// <summary>
    /// Значения по умолчанию для параметра.
    /// </summary>
    public virtual ICollection<MethodologyDefaultParameterValueEntity> DefaultParameterValues { get; set; }
}