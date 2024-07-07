using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Entity ключевого слова.
/// </summary>
[Table("KeyWord")]
public class KeyWordEntity : EntityBase
{
    /// <summary>
    /// Название ключевого слова.
    /// </summary>
    public string Name { get; set; }
}