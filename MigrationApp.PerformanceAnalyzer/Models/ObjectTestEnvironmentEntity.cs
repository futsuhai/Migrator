using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Объект тестовое окружение.
/// </summary>
[Table("ObjectTestEnvironment")]
public class ObjectTestEnvironmentEntity : EntityBase
{
    /// <summary>
    /// Комментарий к ОТО (не отображается в отчете).
    /// </summary>
    public string Comment { get; set; }

    /// <summary>
    /// Характеристики ОТО.
    /// TODO: по-хорошему нужно переименовать поле и согласовать с js.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Назначение объекта.
    /// </summary>
    public string Function { get; set; }

    /// <summary>
    /// Название объекта тестового окружения.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Аппаратное обеспечение ОТО.
    /// </summary>
    public string Hardware { get; set; }

    /// <summary>
    /// Программное обеспечение объекта тестового окружения.
    /// </summary>
    public string Software { get; set; }

    /// <summary>
    /// Является ли аналогичным объекту тестирования.
    /// </summary>
    public bool IsTestObject { get; set; }

    /// <summary>
    /// Связанное оборудование.
    /// </summary>
    public virtual ICollection<EquipmentObjectTestEnvironmentRelationEntity> LinkedEquipment { get; set; }

    /// <summary>
    /// Тестовые окружения.
    /// </summary>
    public virtual ICollection<TestEnvironmentObjectTestEnvironmentRelation> TestEnvironments { get; set; }
}