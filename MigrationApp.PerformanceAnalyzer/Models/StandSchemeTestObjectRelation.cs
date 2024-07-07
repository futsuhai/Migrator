using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь схемы стенда с объектом схемы стенда.
/// </summary>
public class StandSchemeTestObjectRelation : EntityBase
{
    /// <summary>
    /// Количество объектов.
    /// </summary>
    public int Qauntity { get; set; }

    /// <summary>
    /// Является ли кластерным.
    /// </summary>
    public bool IsClustered { get; set; }

    /// <summary>
    /// Идентификатор схемы стенда.
    /// </summary>
    [ForeignKey(nameof(StandScheme))]
    public Guid StandSchemeId { get; set; }

    /// <summary>
    /// Мдентификатор объекта.
    /// </summary>
    [ForeignKey(nameof(TestObject))]
    public Guid TestObjectId { get; set; }

    /// <summary>
    /// Схема стенда.
    /// </summary>
    public virtual StandSchemeEntity StandScheme { get; set; }

    /// <summary>
    /// Объект схемы стенда.
    /// </summary>
    public virtual TestObjectEntity TestObject { get; set; }
}