using System.ComponentModel.DataAnnotations.Schema;
using MigrationApp.Common.Models;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь сущностей и переводов.
/// </summary>
[Table("TranslationRelation")]
public class TranslationRelationEntity : EntityBase
{
    /// <summary>
    /// Переводы.
    /// </summary>
    public virtual ICollection<TranslationEntity> TranslationEntities { get; set; }

    /// <summary>
    /// Получить локализованный текст на текущем языке.
    /// </summary>
    /// <returns>Локализованный текст.</returns>
    public override string ToString()
    {
        var language = Selected.Language;
        return TranslationEntities.SingleOrDefault(x => x.Language == language)?.Text
               ?? TranslationEntities.SingleOrDefault(x => x.Language == "ru")?.Text;
    }
}