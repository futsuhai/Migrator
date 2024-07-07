using System.ComponentModel.DataAnnotations.Schema;
using MigrationApp.PerformanceAnalyzer.Models.Enums;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Пользователь системы.
/// </summary>
[Table("User")]
public class UserEntity : EntityBase
{
    /// <summary>
    /// Логин в Active Directory.
    /// </summary>
    public string AdLogin { get; set; }

    /// <summary>
    /// Организация.
    /// </summary>
    public string Company { get; set; }

    /// <summary>
    /// Группа (тестирования).
    /// </summary>
    public string Group { get; set; }

    /// <summary>
    /// Отдел.
    /// </summary>
    public string Department { get; set; }

    /// <summary>
    /// Электронная почта.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Является роботом.
    /// </summary>
    public bool IsBot { get; set; }

    /// <summary>
    /// Должность.
    /// </summary>
    public string JobPosition { get; set; }

    /// <summary>
    /// Имя пользователя.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Выбранный язык.
    /// </summary>
    public string Language { get; set; }

    /// <summary>
    /// Доступные пользователю роли.
    /// </summary>
    public UserRole Roles { get; set; }

    /// <summary>
    /// Количество активных заявок, доступное пользователю.
    /// </summary>
    public byte? MaxActiveRequests { get; set; }

    /// <summary>
    /// Офис пользователя.
    /// </summary>
    public virtual OfficeEntity Office { get; set; }

    /// <summary>
    /// Настройки методик.
    /// </summary>
    public virtual ICollection<MethodologyUserSettingsEntity> MethodologySettings { get; set; }

    /// <summary>
    /// Связи доступов пользователя в локацию.
    /// </summary>
    public virtual ICollection<LocationAccessRightEntity> AvailableLocations { get; set; }

    /// <summary>
    /// Связи пользователей и проектов.
    /// </summary>
    public virtual ICollection<UserProjectRelation> Projects { get; set; }

    /// <summary>
    /// Протестированные заявки.
    /// </summary>
    public virtual ICollection<RequestEntity> TestedRequests { get; set; }

    /// <summary>
    /// Избранные сборки пользователя.
    /// </summary>
    public virtual ICollection<UserFavoriteBuildRelation> FavoriteBuilds { get; set; }

    /// <summary>
    /// Избранные версии продуктов пользователя.
    /// </summary>
    public virtual ICollection<UserFavoriteProductVersionRelation> FavoriteProductVersoins { get; set; }

    /// <summary>
    /// Избранные продукты пользователя.
    /// </summary>
    public virtual ICollection<UserFavoriteProductRelation> FavoriteProducts { get; set; }

    /// <summary>
    /// Избранные группы продуктов пользователя.
    /// </summary>
    public virtual ICollection<UserFavoriteProductGroupRelation> FavoriteProductGroups { get; set; }

    /// <summary>
    /// Пресеты дашборда М1.
    /// </summary>
    public virtual ICollection<DashboardPresetEntity> DashboardPresets { get; set; }

    /// <summary>
    /// Офис пользователя.
    /// </summary>
    [ForeignKey(nameof(Office))]
    public Guid OfficeId { get; set; }
}