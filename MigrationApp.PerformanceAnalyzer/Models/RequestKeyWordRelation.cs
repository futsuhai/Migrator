using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь заявки и ключевого слова.
/// </summary>
[Table("Request_KeyWordRelation")]
public class RequestKeyWordRelation : EntityBase
{
    /// <summary>
    /// Ключевое слово.
    /// </summary>
    public virtual KeyWordEntity KeyWord { get; set; }

    /// <summary>
    /// Идентификатор ключевого слова.
    /// </summary>
    [ForeignKey("KeyWord")]
    public Guid KeyWordId { get; set; }

    /// <summary>
    /// Заявка.
    /// </summary>
    public virtual RequestEntity Request { get; set; }

    /// <summary>
    /// Идентификатор заявки.
    /// </summary>
    [ForeignKey("Request")]
    public Guid RequestId { get; set; }
}