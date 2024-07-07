using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Хеши конфигураций для замеров.
/// </summary>
[Table("ProductVersion_Build_ResultHash")]
public class ProductVersion_Build_ResultHashEntity : EntityBase
{
    /// <summary>
    /// Версия продукта.
    /// </summary>
    public virtual ProductVersionEntity ProductVersion { get; set; }

    /// <summary>
    /// Идентификатор версии продукта.
    /// </summary>
    [ForeignKey("ProductVersion")]
    public Guid ProductVersionId { get; set; }

    /// <summary>
    /// Номер сборки.
    /// </summary>
    public int AssemblyNumber { get; set; }

    /// <summary>
    /// Методика тестирования.
    /// </summary>
    public virtual MethodologyEntity Methodology { get; set; }

    /// <summary>
    /// Идентификатор методики.
    /// </summary>
    [ForeignKey("Methodology")]
    public Guid? MethodologyId { get; set; }

    /// <summary>
    /// Заявка на тестирование.
    /// </summary>
    public virtual RequestEntity Request { get; set; }

    /// <summary>
    /// Идентификатор заявки.
    /// </summary>
    [ForeignKey("Request")]
    public Guid RequestId { get; set; }

    /// <summary>
    /// Хеш полной конфигурации тестирования.
    /// </summary>
    [MaxLength(32)]
    [MinLength(32)]
    public byte[] Hash { get; set; }

    /// <summary>
    /// Данные о тесте заявки.
    /// </summary>
    public virtual RequestTestEntity RequestTest { get; set; }

    /// <summary>
    /// Идентификатор теста заявки.
    /// </summary>
    [ForeignKey("RequestTest")]
    public Guid RequestTestId { get; set; }

    /// <summary>
    /// Значение итерируемого параметра.
    /// </summary>
    public virtual ParameterValueEntity IterParameterValue { get; set; }

    /// <summary>
    /// Идентификатор значения итерируемого параметра.
    /// </summary>
    [ForeignKey("IterParameterValue")]
    public Guid IterParameterValueId { get; set; }
}