using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using MigrationApp.PerformanceAnalyzer.Models.Enums;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Entity файла методики.
/// </summary>
[Table("MethodologyFile")]
public class MethodologyFileEntity : EntityBase
{
    /// <summary>
    /// Файл в хранилище.
    /// </summary>
    public virtual StorageFileEntity StorageFile { get; set; }

    /// <summary>
    /// Описание файла.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Шаблон ли.
    /// </summary>
    public bool IsTemplate { get; set; }

    /// <summary>
    /// Методика, к которой относится файл.
    /// </summary>
    [JsonIgnore] // Эта хрень ломает swagger ui непроверяемой циклической ссылкой. Или api хрень. В общем, велосипед. Если убрать и заработает, подарю шоколадку или скину деньги.
    public virtual MethodologyEntity Methodology { get; set; }

    /// <summary>
    /// Идентификатор методики.
    /// </summary>
    [ForeignKey("Methodology")]
    public Guid MethodologyId { get; set; }

    /// <summary>
    /// Тип файла методики.
    /// </summary>
    public MethodologyFileType Type { get; set; }

    /// <summary>
    /// Язык, на котором отображается файл.
    /// <value>NULL - Отображается для всех языков.</value>
    /// <value>Двубуквенное название локали по ISO-639-1 ("ru", "en", "de").</value>
    /// </summary>
    public string Language { get; set; }

    /// <summary>
    /// Значения параметров, влияющие на видимость файла.
    /// </summary>
    [JsonIgnore] // Эта хрень ломает swagger ui непроверяемой циклической ссылкой. Или api хрень. В общем, велосипед. Если убрать и заработает, подарю шоколадку или скину деньги.
    public virtual ICollection<MethodologyFileParameterValueRelationEntity> ValuesAffectingVisibility { get; set; }

    /// <summary>
    /// Связи со схемами стенда.
    /// </summary>
    [JsonIgnore] // Эта хрень ломает swagger ui непроверяемой циклической ссылкой. Или api хрень. В общем, велосипед. Если убрать и заработает, подарю шоколадку или скину деньги.
    public virtual ICollection<MethodologyStand_MethodologyFileRelation> StandSchemeRelations { get; set; }

    /// <summary>
    /// Идентификатор файла в хранилище.
    /// </summary>
    [ForeignKey(nameof(StorageFile))]
    public Guid? StorageFileId { get; set; }
}