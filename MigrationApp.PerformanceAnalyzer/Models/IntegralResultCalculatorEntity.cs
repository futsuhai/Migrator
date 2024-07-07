namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Калькулятор интегрального показателя.
/// </summary>
public class IntegralResultCalculatorEntity : EntityBase
{
    /// <summary>
    /// Название.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Описание.
    /// </summary>
    public string? Description { get; set; }
}