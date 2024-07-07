using System.ComponentModel.DataAnnotations.Schema;
using MigrationApp.PerformanceAnalyzer.Models.Enums;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Продукт.
/// </summary>
[Table("Product")]
public class ProductEntity : EntityBase
{
    /// <summary>
    /// Feature Set'ы.
    /// </summary>
    public virtual ICollection<ProductFeatureSetRelationEntity> FeatureSets { get; set; }

    /// <summary>
    /// Feature Set'ы включены.
    /// </summary>
    public bool FeatureSetsEnabled { get; set; }

    /// <summary>
    /// Требования к тестам, переопределяющие требования методики.
    /// </summary>
    public CalibrationTestsScheme ForcedTestsScheme { get; set; }

    /// <summary>
    /// Является ли черновиком.
    /// </summary>
    public bool IsDraft { get; set; }

    /// <summary>
    /// Название продукта.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Категория продукта.
    /// </summary>
    public ProductCategory ProductCategory { get; set; }

    /// <summary>
    /// Группа продуктов.
    /// </summary>
    public virtual ProductGroupEntity ProductGroup { get; set; }

    /// <summary>
    /// Идентификатор группы продуктов.
    /// </summary>
    [ForeignKey("ProductGroup")]
    public Guid ProductGroupId { get; set; }

    /// <summary>
    /// Краткое описание.
    /// </summary>
    public string ShortDescription { get; set; }

    /// <summary>
    /// Можно создавать заявку на основе файла.
    /// </summary>
    public bool CanCreateRequestFromFile { get; set; }

    /// <summary>
    /// Поддержка загрузки файла с целями.
    /// </summary>
    public bool TargetFileSupport { get; set; }

    /// <summary>
    /// Идентификатор продукта по номенклатуре ОВА.
    /// </summary>
    [Obsolete("Использовать OvaDistributions")]
    public string OvaId { get; set; }

    /// <summary>
    /// Дистрибутив в OVA.
    /// </summary>
    public virtual ICollection<ProductOvaDistributionRelation> OvaDistributions { get; set; }

    /// <summary>
    /// Версии продукта.
    /// </summary>
    public virtual ICollection<ProductVersionEntity> Versions { get; set; }

    /// <summary>
    /// Переводы для продукта.
    /// </summary>
    public virtual ICollection<ProductTranslationEntity> Translations { get; set; }
}