using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Переводы для продукта.
/// </summary>
[Table("ProductTranslation")]
public class ProductTranslationEntity : EntityBase
{
    /// <summary>
    /// Методика.
    /// </summary>
    [JsonIgnore]
    public virtual ProductEntity Product { get; set; }

    /// <summary>
    /// Идентификатор методики.
    /// </summary>
    [ForeignKey("Product")]
    public Guid ProductId { get; set; }

    /// <summary>
    /// Язык.
    /// </summary>
    public string Language { get; set; }

    /// <summary>
    /// Краткое описание.
    /// </summary>
    public string ShortDescription { get; set; }
}