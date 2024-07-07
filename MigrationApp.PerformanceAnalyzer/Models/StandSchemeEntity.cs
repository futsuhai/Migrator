namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Схема стенда.
/// </summary>
public class StandSchemeEntity : EntityBase
{
    /// <summary>
    /// Название.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Объекты схемы.
    /// </summary>
    public virtual ICollection<StandSchemeTestObjectRelation> TestObjects { get; set; }
}