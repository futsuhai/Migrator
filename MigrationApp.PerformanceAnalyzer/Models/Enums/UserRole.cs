namespace MigrationApp.PerformanceAnalyzer.Models.Enums;

/// <summary>
/// Роли пользователей.
/// </summary>
[Flags]
public enum UserRole
{
    /// <summary>
    /// Анонимный пользователь или гость.
    /// </summary>
    Guest = 0,

    /// <summary>
    /// Заказчик.
    /// </summary>
    Customer = 1,

    /// <summary>
    /// Менеджер ресурсов.
    /// </summary>
    Manager = 1 << 1,

    /// <summary>
    /// Тестировщик.
    /// </summary>
    Tester = 1 << 2,

    /// <summary>
    /// Эксперт.
    /// </summary>
    Expert = 1 << 3,

    /// <summary>
    /// Администратор.
    /// </summary>
    Administrator = 1 << 4,

    /// <summary>
    /// Директор ЦРПП.
    /// </summary>
    SddDirector = 1 << 5,

    /// <summary>
    /// Разработчик.
    /// </summary>
    Developer = 1 << 6,
}