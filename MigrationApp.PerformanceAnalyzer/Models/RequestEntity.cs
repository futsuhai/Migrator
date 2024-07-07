using System.ComponentModel.DataAnnotations.Schema;
using MigrationApp.PerformanceAnalyzer.Models.Enums;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Заявка на нагрузочное тестирование.
/// </summary>
[Table("Request")]
public class RequestEntity : EntityBase
{
    /// <summary>
    /// Идентификатор сборки.
    /// </summary>
    [ForeignKey(nameof(Build))]
    public Guid? BuildId { get; set; }

    /// <summary>
    /// Сборка.
    /// </summary>
    public virtual BuildEntity Build { get; set; }

    /// <summary>
    /// Причина изменения номера сборки.
    /// </summary>
    public string AssemblyNumberChangeReason { get; set; }

    /// <summary>
    /// Чек-лист пройден.
    /// </summary>
    public bool? CheckListIsPassed { get; set; }

    /// <summary>
    /// Время закрытия заявки заказчиком.
    /// </summary>
    public DateTime? CloseDate { get; set; }

    /// <summary>
    /// Цвет екшена.
    /// </summary>
    public EquipmentActionColor Color { get; set; }

    /// <summary>
    /// Комментарий.
    /// </summary>
    public string Comment { get; set; }

    /// <summary>
    /// Выводы.
    /// </summary>
    public string Conclusion { get; set; }

    /// <summary>
    /// Запрос на исправление выводов.
    /// </summary>
    public string ConclusionAmendmentRequest { get; set; }

    /// <summary>
    /// Дата создания.
    /// </summary>
    public DateTime CreationDate { get; set; }

    /// <summary>
    /// Комментарий заказчика.
    /// </summary>
    public string CustomerRequirements { get; set; }

    /// <summary>
    /// Желаемая дата окончания тестирования.
    /// </summary>
    public DateTime? DesiredCompletionDate { get; set; }

    /// <summary>
    /// Дата окончания тестирования и генерации отчета тестировщиком.
    /// </summary>
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Ключевые слова.
    /// </summary>
    public string KeyWords { get; set; }

    /// <summary>
    /// Дата окончания обработки заявки менеджером ресуросов.
    /// </summary>
    public DateTime? ManagerProcessedDate { get; set; }

    /// <summary>
    /// Рекомендации.
    /// </summary>
    public string Recommendation { get; set; }

    /// <summary>
    /// Короткий идентификатор.
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int ShortId { get; set; }

    /// <summary>
    /// Дата начала резерва оборудования.
    /// </summary>
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Дата начало тестирования по заявке.
    /// </summary>
    public DateTime? StartTestDate { get; set; }

    /// <summary>
    /// Статус заявки.
    /// </summary>
    [Column("StatusId")]
    public RequestStatus Status { get; set; }

    /// <summary>
    /// Идентификатор заказчика.
    /// </summary>
    [ForeignKey(nameof(Customer))]
    public Guid CustomerId { get; set; }

    /// <summary>
    /// Идентификатор эксперта.
    /// </summary>
    [ForeignKey(nameof(Expert))]
    public Guid? ExpertId { get; set; }

    /// <summary>
    /// Идентификатор Feature-Set.
    /// </summary>
    [ForeignKey(nameof(FeatureSet))]
    public Guid? FeatureSetId { get; set; }

    /// <summary>
    /// Идентификатор АП заявки.
    /// </summary>
    [ForeignKey(nameof(HardwarePlatform))]
    public Guid? HardwarePlatformId { get; set; }

    /// <summary>
    /// Локация.
    /// </summary>
    [ForeignKey(nameof(Location))]
    public Guid? LocationId { get; set; }

    /// <summary>
    /// Идентификатор методики.
    /// </summary>
    [ForeignKey(nameof(Methodology))]
    public Guid? MethodologyId { get; set; }

    /// <summary>
    /// Идентификатор ОС заявки.
    /// </summary>
    [ForeignKey(nameof(OperationSystem))]
    public Guid? OperationSystemId { get; set; }

    /// <summary>
    /// Идентификатор версии продукта.
    /// </summary>
    [ForeignKey(nameof(ProductVersion))]
    public Guid ProductVersionId { get; set; }

    /// <summary>
    /// Идентификатор выбранного сценария.
    /// </summary>
    [ForeignKey(nameof(Scenario))]
    public Guid? ScenarioId { get; set; }

    /// <summary>
    /// Идентификатор тестового окружения.
    /// </summary>
    [ForeignKey(nameof(TestEnvironment))]
    public Guid? TestEnvironmentId { get; set; }

    /// <summary>
    /// Идентификатор тестировщика.
    /// </summary>
    [ForeignKey(nameof(Tester))]
    public Guid? TesterId { get; set; }

    /// <summary>
    /// Идентификатор менеджера ресурсов.
    /// </summary>
    [ForeignKey(nameof(ResourceManager))]
    public Guid? ResourceManagerId { get; set; }

    /// <summary>
    /// Заказчик.
    /// </summary>
    [InverseProperty("TestedRequests")]
    public virtual UserEntity Customer { get; set; }

    /// <summary>
    /// Резервирования оборудования в рамках заявки.
    /// </summary>
    public virtual ICollection<EquipmentRequestReserveActionEntity> EquipmentRequestReserveActions { get; set; }

    /// <summary>
    /// Эксперт.
    /// </summary>
    public virtual UserEntity Expert { get; set; }

    /// <summary>
    /// Feature-Set.
    /// </summary>
    public virtual FeatureSetEntity FeatureSet { get; set; }

    /// <summary>
    /// АП заявки.
    /// </summary>
    public virtual HardwarePlatformEntity HardwarePlatform { get; set; }

    /// <summary>
    /// Локация.
    /// </summary>
    public virtual LocationEntity Location { get; set; }

    /// <summary>
    /// Методика тестирования.
    /// </summary>
    public virtual MethodologyEntity Methodology { get; set; }

    /// <summary>
    /// ОС заявки.
    /// </summary>
    public virtual OperationSystemEntity OperationSystem { get; set; }

    /// <summary>
    /// Параметры заявки.
    /// </summary>
    public virtual ICollection<RequestParameterValueRelation> ParameterValues { get; set; }

    /// <summary>
    /// Версия продукта.
    /// </summary>
    public virtual ProductVersionEntity ProductVersion { get; set; }

    /// <summary>
    /// Файлы отчётов.
    /// </summary>
    public virtual ICollection<RequestReportFileEntity> ReportFiles { get; set; }

    /// <summary>
    /// Элементы бандловых заявок.
    /// </summary>
    public virtual ICollection<RequestBundleItemEntity> RequestBundleItems { get; set; }

    /// <summary>
    /// Файлы  связанные с заявкой.
    /// </summary>
    public virtual ICollection<RequestFileEntity> RequestFiles { get; set; }

    /// <summary>
    /// Общие результаты заявки.
    /// </summary>
    public virtual ICollection<RequestResultDataEntity> RequestResults { get; set; }

    /// <summary>
    /// Тесты в рамках заявки.
    /// </summary>
    public virtual ICollection<RequestTestEntity> RequestTests { get; set; }

    /// <summary>
    /// Выбранный сценарий тестирования.
    /// </summary>
    public virtual MethodologyScenarioEntity Scenario { get; set; }

    /// <summary>
    /// Тестовое окружение.
    /// </summary>
    public virtual TestEnvironmentEntity TestEnvironment { get; set; }

    /// <summary>
    /// Тестировщик.
    /// </summary>
    public virtual UserEntity Tester { get; set; }

    /// <summary>
    /// Менеджер ресурсов.
    /// </summary>
    public virtual UserEntity ResourceManager { get; set; }

    /// <summary>
    /// История заявки.
    /// </summary>
    public virtual ICollection<RequestChangesHistoryEntity> History { get; set; }

    /// <summary>
    /// История ревью заявки.
    /// </summary>
    public virtual ICollection<RequestReviewEntity> Reviews { get; set; }

    /// <summary>
    /// Связи ключевых слов.
    /// </summary>
    public virtual ICollection<RequestKeyWordRelation> KeyWordRelations { get; set; }

    /// <summary>
    /// Последнее сообщение генерации отчета (сообщение об ошибке).
    /// </summary>
    public string ReportStatus { get; set; }
}