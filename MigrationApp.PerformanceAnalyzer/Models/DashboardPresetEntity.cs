using System.ComponentModel.DataAnnotations.Schema;
using MigrationApp.PerformanceAnalyzer.Models.Enums;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Пресет фильтра для дашборда директора ЦРПП.
/// </summary>
public class DashboardPresetEntity : EntityBase
{
    /// <summary>
    /// Название пресета.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Пользователь.
    /// </summary>
    public virtual UserEntity User { get; set; }

    /// <summary>
    /// Дата начала промежутка выборки сборок.
    /// </summary>
    public DateTime? MinBuildDate { get; set; }

    /// <summary>
    /// Дата окончания промежутка выборки сборок.
    /// </summary>
    public DateTime? MaxBuildDate { get; set; }

    /// <summary>
    /// Включенные типы сборок.
    /// </summary>
    public BuildTypeFlag BuildTypes { get; set; }

    /// <summary>
    /// Включенные статусы методик.
    /// </summary>
    public MethodologyStatusFlag MethodologyStatuses { get; set; }

    /// <summary>
    /// Включенные типы тестирования.
    /// </summary>
    public MethodologyTestingTypeFlag TestingTypes { get; set; }

    /// <summary>
    /// Продукты, включенные в пресет.
    /// </summary>
    public virtual ICollection<DashboardPresetProductRelation> Products { get; set; }

    /// <summary>
    /// Идентификатор пользователя.
    /// </summary>
    [ForeignKey(nameof(User))]
    public Guid UserId { get; set; }
}