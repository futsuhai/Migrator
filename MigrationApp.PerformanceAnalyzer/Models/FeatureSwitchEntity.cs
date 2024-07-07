namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Сущность для переключения и настройки фич.
/// </summary>
public class FeatureSwitchEntity : EntityBase
{
    /// <summary>
    /// Название.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Кодовое название фичи.
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Описание.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Включена ли фича.
    /// </summary>
    public bool Enabled { get; set; }

    /// <summary>
    /// Конфигурация фичи.
    /// </summary>
    public string Configuration { get; set; }
}