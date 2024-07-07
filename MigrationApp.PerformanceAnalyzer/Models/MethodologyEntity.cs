using System.ComponentModel.DataAnnotations.Schema;
using MigrationApp.PerformanceAnalyzer.Models.Enums;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Методика нагрузочного тестирования.
/// </summary>
[Table("Methodology")]
public class MethodologyEntity : EntityBase
{
    /// <summary>
    /// Пользовательские настройки.
    /// </summary>
    public virtual ICollection<MethodologyUserSettingsEntity> UserSettings { get; set; }

    /// <summary>
    /// Схемы стенда.
    /// </summary>
    public virtual ICollection<MethodologyStandEntity> Stands { get; set; }

    /// <summary>
    /// Возможно ли наличие показателей здоровья.
    /// </summary>
    public bool CanHaveHealthCharts { get; set; }

    /// <summary>
    /// Показатели здоровья грузятся в каждый тест.
    /// </summary>
    public bool AreHealthChartsPerTest { get; set; }

    /// <summary>
    /// Имеет графики.
    /// </summary>
    public bool HasCharts { get; set; }

    /// <summary>
    /// Полное название.
    /// </summary>
    public virtual TranslationRelationEntity FullName { get; set; }

    /// <summary>
    /// Идентификатор имени.
    /// </summary>
    [ForeignKey(nameof(FullName))]
    public Guid FullNameId { get; set; }

    /// <summary>
    /// Стратегия обработки файлов результатов.
    /// </summary>
    public virtual MethodologyParsingStrategyEntity MethodologyParsingStrategy { get; set; }

    /// <summary>
    /// Идентификатор итерируемого параметра.
    /// </summary>
    [ForeignKey(nameof(IterParameter))]
    public Guid? IterParameterId { get; set; }

    /// <summary>
    /// Идентификатор ключевого параметра.
    /// </summary>
    [ForeignKey(nameof(ChartGroupingParameter))]
    public Guid? ChartGroupingParameterId { get; set; }

    /// <summary>
    /// Идентификатор основного параметра для целей по методике.
    /// </summary>
    [ForeignKey(nameof(MainTargetParameter))]
    public Guid? MainTargetParameterId { get; set; }

    /// <summary>
    /// Путь к шаблону отчета.
    /// </summary>
    public string ReportPath { get; set; }

    /// <summary>
    /// Подзаголовок отчета.
    /// </summary>
    public virtual TranslationRelationEntity ReportSubTitle { get; set; }

    /// <summary>
    /// Подзаголовок отчета.
    /// </summary>
    [ForeignKey(nameof(ReportSubTitle))]
    public Guid ReportSubTitleId { get; set; }

    /// <summary>
    /// Ответственный эксперт.
    /// </summary>
    public virtual UserEntity ResponsibleExpert { get; set; }

    /// <summary>
    /// Ответственный эксперт.
    /// </summary>
    [ForeignKey("ResponsibleExpert")]
    public Guid? ResponsibleExpertId { get; set; }

    /// <summary>
    /// Результирующие параметры для методики.
    /// </summary>
    public virtual ICollection<MethodologyResultParameterRelation> ResultParametersRelations { get; set; }

    /// <summary>
    /// Параметры методики.
    /// </summary>
    public virtual ICollection<MethodologyParameterRelation> ParameterRelations { get; set; }

    /// <summary>
    /// Сценарии тестирования для методики.
    /// </summary>
    public virtual ICollection<MethodologyScenarioEntity> MethodologyScenarios { get; set; }

    /// <summary>
    /// Языки, на которых доступна методика.
    /// </summary>
    public virtual ICollection<MethodologyLanguageRelation> AvailableLanguages { get; set; }

    /// <summary>
    /// Группы параметров.
    /// </summary>
    public virtual ICollection<MethodologyParametersGroup> ParametersGroups { get; set; }

    /// <summary>
    /// Краткое описание.
    /// </summary>
    public virtual TranslationRelationEntity ShortDescription { get; set; }

    /// <summary>
    /// Краткое описание.
    /// </summary>
    [ForeignKey(nameof(ShortDescription))]
    public Guid ShortDescriptionId { get; set; }

    /// <summary>
    /// Статус методики.
    /// </summary>
    public MethodologyStatus Status { get; set; }

    /// <summary>
    /// Требования к стандартным тестам методики.
    /// </summary>
    public StandartTestsScheme StandartTestsScheme { get; set; }

    /// <summary>
    /// Требования к калибровочным тестам методики.
    /// </summary>
    public CalibrationTestsScheme CalibrationTestsScheme { get; set; }

    /// <summary>
    /// Используется ли кастомная таблица результатов.
    /// </summary>
    public bool CustomResultTableEnabled { get; set; }

    /// <summary>
    /// Используется ли таблица результатов по умолчанию.
    /// </summary>
    public bool DefaultResultTableEnabled { get; set; }

    /// <summary>
    /// Требуется ли раздельная загрузка результатов на итерируемые параметры.
    /// </summary>
    public bool AreIterParameterFilesSeparated { get; set; }

    /// <summary>
    /// Требуется ли раздельная загрузка результатов на показатели.
    /// </summary>
    public bool AreResultParameterFilesSeparated { get; set; }

    /// <summary>
    /// Тип группировки параметров.
    /// </summary>
    public ParameterGroupType ParameterGroupType { get; set; }

    /// <summary>
    /// Код методики.
    /// </summary>
    public string TestCode { get; set; }

    /// <summary>
    /// Можно ли тестировщику загружать общие файлы не обрабатываемые VPA (только для хранения).
    /// </summary>
    public bool CanTesterUploadCommonFiles { get; set; }

    /// <summary>
    /// Разрешенные расширения файлов для загрузки, разделенные запятой.
    /// </summary>
    public string CommonFilesExtensions { get; set; }

    /// <summary>
    /// Псевдоним для Common files title.
    /// </summary>
    public string CommonFilesTitleAlias { get; set; }

    /// <summary>
    /// Основание для проведения тестирования.
    /// </summary>
    public virtual TranslationRelationEntity TestingReason { get; set; }

    /// <summary>
    /// Основание для проведения тестирования.
    /// </summary>
    [ForeignKey(nameof(TestingReason))]
    public Guid TestingReasonId { get; set; }

    /// <summary>
    /// Поставленные задачи (TinyMCE).
    /// </summary>
    public virtual TranslationRelationEntity SubTasks { get; set; }

    /// <summary>
    /// Поставленные задачи (TinyMCE).
    /// </summary>
    [ForeignKey(nameof(SubTasks))]
    public Guid SubTasksId { get; set; }

    /// <summary>
    /// Критерий завершения тестирования.
    /// </summary>
    public virtual TranslationRelationEntity TestsFinishCriterion { get; set; }

    /// <summary>
    /// Критерий завершения тестирования.
    /// </summary>
    [ForeignKey(nameof(TestsFinishCriterion))]
    public Guid TestsFinishCriterionId { get; set; }

    /// <summary>
    /// Тип тестирования.
    /// </summary>
    public MethodologyTestingType TestingType { get; set; }

    /// <summary>
    /// Точность оценки.
    /// </summary>
    public MethodologyAssessmentAccuracy AssessmentAccuracy { get; set; }

    /// <summary>
    /// Версия.
    /// </summary>
    public string Version { get; set; }

    /// <summary>
    /// Итерируемый параметр (не использовать для группировки графиков!).
    /// </summary>
    public virtual ParameterEntity IterParameter { get; set; }

    /// <summary>
    /// Ключевой параметр для группировки данных графиков и сравнения.
    /// </summary>
    public virtual ParameterEntity ChartGroupingParameter { get; set; }

    /// <summary>
    /// Основной параметр для целей по методике.
    /// </summary>
    public virtual ParameterEntity MainTargetParameter { get; set; }

    /// <summary>
    /// Связанные заявки.
    /// </summary>
    public virtual ICollection<RequestEntity> Requests { get; set; }

    /// <summary>
    /// Связанные версии продуктов.
    /// </summary>
    public virtual ICollection<ProductVersionMethodologyRelation> ProductVersionRelations { get; set; }

    /// <summary>
    /// Файлы методики.
    /// </summary>
    public virtual ICollection<MethodologyFileEntity> MethodologyFiles { get; set; }

    /// <summary>
    /// Блоки отчета.
    /// </summary>
    public virtual ICollection<Methodology_ReportPartRelation> ReportParts { get; set; }

    /// <summary>
    /// Шаги чек-листа.
    /// </summary>
    public virtual ICollection<CheckListStepEntity> CheckListSteps { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return TestCode;
    }
}