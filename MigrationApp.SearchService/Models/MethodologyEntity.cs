using MigrationApp.SearchService.Models.Enums;

namespace MigrationApp.SearchService.Models;

/// <summary>
/// Данные методики.
/// </summary>
public class MethodologyEntity
{
    /// <summary>
    /// Идентификатор методики.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Имя методики.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Статус методик.
    /// </summary>
    public MethodologyStatus Status { get; set; }

    /// <summary>
    /// Имя эксперта.
    /// </summary>
    public string? ExpertName { get; set; }

    /// <summary>
    /// Доступна ли методика только на русском языке.
    /// </summary>
    public bool OnlyRussian { get; set; }

    /// <summary>
    /// Описание методики на русском.
    /// </summary>
    public string RuDescription { get; set; }

    /// <summary>
    /// Описание методики на английском.
    /// </summary>
    public string EnDescription { get; set; }

    /// <summary>
    /// Описание методики на немецком.
    /// </summary>
    public string? DeDescription { get; set; }

    /// <summary>
    /// Локации, на которых доступно тестирование по методике.
    /// </summary>
    public virtual ICollection<MethodologyLocationRelation> Locations { get; set; }

    /// <summary>
    /// Продукты, на которых доступно тестирование по методике.
    /// </summary>
    public virtual ICollection<MethodologyProductRelation> Products { get; set; }
}