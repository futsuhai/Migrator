namespace MigrationApp.Common.Models;

/// <summary>
/// Интерфейс сущностей.
/// </summary>
public interface IEntity
{
    /// <summary>
    /// Идентификатор сущности.
    /// </summary>
    public Guid Id { get; set; }
}