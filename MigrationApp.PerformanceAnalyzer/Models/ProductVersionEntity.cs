using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Версия продукта.
/// </summary>
[Table("ProductVersion")]
public class ProductVersionEntity : EntityBase
{
    /// <summary>
    /// Является ли черновиком.
    /// </summary>
    public bool IsDraft { get; set; }

    /// <summary>
    /// Бандлы методик для тестирования продукта.
    /// </summary>
    public virtual ICollection<ProductVersionMethodologyBundleRelation> BundleRelations { get; set; }

    /// <summary>
    /// Методики для тестирования продукта.
    /// </summary>
    public virtual ICollection<ProductVersionMethodologyRelation> MethodologyRelations { get; set; }

    /// <summary>
    /// Название версии продукта.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// ОС продукта.
    /// </summary>
    public virtual ICollection<ProductVersionOperationSystemRelation> OperationSystemRelations { get; set; }

    /// <summary>
    /// Параметры продукта.
    /// </summary>
    public virtual ICollection<ProductVersionParameterValueRelation> ParameterValueRelations { get; set; }

    /// <summary>
    /// Параметры продукта по умолчанию.
    /// </summary>
    public virtual ICollection<ProductVersionDefaultParameterValueRelation> DefaultParameterValueRelations { get; set; }

    /// <summary>
    /// Файлы целевых показателей.
    /// </summary>
    public virtual ICollection<ProductVersionTargetFileRelation> TargetFileRelations { get; set; }

    /// <summary>
    /// Продукт.
    /// </summary>
    public virtual ProductEntity Product { get; set; }

    /// <summary>
    /// Идентификатор продукта.
    /// </summary>
    [ForeignKey("Product")]
    public Guid ProductId { get; set; }

    /// <summary>
    /// Информация о менеджере продукта.
    /// </summary>
    public virtual UserEntity ProductManager { get; set; }

    /// <summary>
    /// Идентификатор менеджера продукта.
    /// </summary>
    [ForeignKey("ProductManager")]
    public Guid? ProductManagerId { get; set; }

    /// <summary>
    /// Информация о менеджере проекта.
    /// </summary>
    public virtual ProjectEntity Project { get; set; }

    /// <summary>
    /// Заявки.
    /// </summary>
    public virtual ICollection<RequestEntity> Requests { get; set; }

    /// <summary>
    /// Идентификатор менеджера проекта.
    /// </summary>
    [ForeignKey("Project")]
    public Guid? ProjectId { get; set; }

    /// <summary>
    /// Целевые показатели.
    /// </summary>
    public virtual ICollection<TargetNewEntity> Targets { get; set; }
}