using System.ComponentModel.DataAnnotations;

namespace MigrationApp.Common.Models;

/// <summary>
///     Интерфейс сущности в БД.
/// </summary>
public interface IEntityBase
{
    /// <summary>
    ///     Идентификатор.
    /// </summary>
    [Key]
    Guid Id { get; set; }

    /// <summary>
    /// Дата создания.
    /// </summary>
    DateTime CreatedAt { get; set; }

    /// <summary>
    /// Дата изменения.
    /// </summary>
    DateTime ModifiedAt { get; set; }

    /// <summary>
    /// Автор изменения.
    /// </summary>
    Guid ModifiedBy { get; set; }

    /// <summary>
    /// Автор создания.
    /// </summary>
    Guid CreatedBy { get; set; }
}