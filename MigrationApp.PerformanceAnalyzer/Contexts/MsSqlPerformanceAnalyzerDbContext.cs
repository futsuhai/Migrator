using Microsoft.EntityFrameworkCore;
using MigrationApp.PerformanceAnalyzer.Models;

namespace MigrationApp.PerformanceAnalyzer.Contexts;

/// <summary>
/// MS SQL контекст PerformanceAnalyzer.
/// </summary>
public class MsSqlPerformanceAnalyzerDbContext : DbContext
{
    public MsSqlPerformanceAnalyzerDbContext(DbContextOptions<MsSqlPerformanceAnalyzerDbContext> options)
        : base(options) { }
    
    /// <summary>
    /// Сущность билда.
    /// </summary>
    public DbSet<BuildEntity> Build { get; set; }
    
    /// <summary>
    /// Пункт чек-листа.
    /// </summary>
    public DbSet<CheckListStepEntity> CheckListStep { get; set; }
    
    /// <summary>
    /// Город.
    /// </summary>
    public DbSet<CityEntity> City { get; set; }
    
    /// <summary>
    /// Конфигурация.
    /// </summary>
    public DbSet<ConfigurationEntity> Configuration { get; set; }
    
    /// <summary>
    /// Связь конфигурации и значения параметра.
    /// </summary>
    public DbSet<Configuration_ParameterValueRelation> Configuration_ParameterValueRelation { get; set; }
    
    /// <summary>
    /// Связь конфигурации и значения параметра.
    /// </summary>
    public DbSet<Configuration_ResultParameterRelation> Configuration_ResultParameterRelation { get; set; }
    
    /// <summary>
    /// Псевдоним конфигурации.
    /// </summary>
    public DbSet<ConfigurationAliasEntity> ConfigurationAliasEntities { get; set; }
    
    /// <summary>
    /// Пресет фильтра для дашборда директора ЦРПП.
    /// </summary>
    public DbSet<DashboardPresetEntity> DashboardPresetEntities { get; set; }
    
    /// <summary>
    /// Связь пресета дашборда с продуктом.
    /// </summary>
    public DbSet<DashboardPresetProductRelation> DashboardPresetProductRelations { get; set; }
    
    /// <summary>
    /// Entity парсеров.
    /// </summary>
    public DbSet<DataParserEntity> DataParser { get; set; }
    
    /// <summary>
    /// Единица оборудования, выведенного из эксплуатации.
    /// </summary>
    public DbSet<DecommissionedEquipmentEntity> DecommissionedEquipment { get; set; }
    
    /// <summary>
    /// Единица оборудования.
    /// </summary>
    public DbSet<EquipmentEntity> Equipment { get; set; }
    
    /// <summary>
    /// Связь оборудования и АП.
    /// </summary>
    public DbSet<EquipmentHardwarePlatformRelationEntity> Equipment_HardwarePlatformRelation { get; set; }
    
    /// <summary>
    /// Связь оборудования и ОТО.
    /// </summary>
    public DbSet<EquipmentObjectTestEnvironmentRelationEntity> Equipment_ObjectTestEnvironmentRelation { get; set; }
    
    /// <summary>
    /// Действие над оборудованием.
    /// </summary>
    public DbSet<EquipmentActionEntity> EquipmentAction { get; set; }
    
    /// <summary>
    /// Резерв эксперта.
    /// </summary>
    public DbSet<EquipmentExpertReserveEntity> EquipmentExpertReserve { get; set; }
    
    /// <summary>
    /// Действие по заказу оборудования экспертом.
    /// </summary>
    public DbSet<EquipmentExpertReserveActionEntity> EquipmentExpertReserveAction { get; set; }
    
    /// <summary>
    /// Заметка о результатах деятельности эксперта.
    /// </summary>
    public DbSet<EquipmentExpertReserveResultReviewEntity> EquipmentExpertReserveResultReview { get; set; }
    
    /// <summary>
    /// Резервирование по заявке.
    /// </summary>
    public DbSet<EquipmentRequestReserveActionEntity> EquipmentRequestReserveAction { get; set; }
    
    /// <summary>
    /// Оборудование временно недоступно.
    /// </summary>
    public DbSet<EquipmentTemporarilyUnavailableActionEntity> EquipmentTemporarilyUnavailableAction { get; set; }
    
    /// <summary>
    /// Feature Set.
    /// </summary>
    public DbSet<FeatureSetEntity> FeatureSet { get; set; }
    
    /// <summary>
    /// Сущность для переключения и настройки фич.
    /// </summary>
    public DbSet<FeatureSwitchEntity> FeatureSwitchEntities { get; set; }
    
    /// <summary>
    /// Извлекатель данных из файла.
    /// </summary>
    public DbSet<FileParsingDataExtractorEntity> FileParsingDataExtractorEntities { get; set; }
    
    /// <summary>
    /// Сущность из таблицы настроек.
    /// </summary>
    public DbSet<GlobalSettingsEntity> GlobalSettings { get; set; }
    
    /// <summary>
    /// Entity аппаратного обеспечения.
    /// </summary>
    public DbSet<HardwarePlatformEntity> HardwarePlatform { get; set; }
    
    /// <summary>
    /// Связь аппаратной платформы со значениями по умолчанию.
    /// </summary>
    public DbSet<HardwarePlatformDefaultParameterValueRelation> HardwarePlatform_DefaultParameterValueRelation { get; set; }
    
    /// <summary>
    /// Связь аппаратной платформы с операционной системой.
    /// </summary>
    public DbSet<HardwarePlatformOperationSystemRelation> HardwarePlatform_OperationSystemRelation { get; set; }
    
    /// <summary>
    /// Связь аппаратной платформы со значением параметра.
    /// </summary>
    public DbSet<HardwarePlatformParameterValueRelation> HardwarePlatform_ParameterValueRelation { get; set; }
    
    /// <summary>
    /// Entity файла аппаратной платформы.
    /// </summary>
    public DbSet<HardwarePlatformFileEntity> HardwarePlatformFile { get; set; }
    
    /// <summary>
    /// Калькулятор интегрального показателя.
    /// </summary>
    public DbSet<IntegralResultCalculatorEntity> IntegralResultCalculatorEntities { get; set; }
    
    /// <summary>
    /// Entity ключевого слова.
    /// </summary>
    public DbSet<KeyWordEntity> KeyWord { get; set; }
    
    /// <summary>
    /// Локация.
    /// </summary>
    public DbSet<LocationEntity> Location { get; set; }
    
    /// <summary>
    /// Доступ к локации.
    /// </summary>
    public DbSet<LocationAccessRightEntity> LocationAccessRight { get; set; }
    
    /// <summary>
    /// Методика нагрузочного тестирования.
    /// </summary>
    public DbSet<MethodologyEntity> Methodology { get; set; }
    
    /// <summary>
    /// Набор дефолтных значений для методики.
    /// </summary>
    public DbSet<MethodologyDefaultParameterValueEntity> Methodology_DefaultParameterValue { get; set; }
    
    /// <summary>
    /// Связь методики и оппаратной платформы.
    /// </summary>
    public DbSet<MethodologyHardwarePlatformRelation> Methodology_HardwarePlatformRelation { get; set; }
    
    /// <summary>
    /// Привязка возможного языка для методики.
    /// </summary>
    public DbSet<MethodologyLanguageRelation> Methodology_LanguageRelation { get; set; }
    
    /// <summary>
    /// Связь методики и параметра.
    /// </summary>
    public DbSet<MethodologyParameterRelation> Methodology_ParameterRelation { get; set; }
    
    /// <summary>
    /// Триггер видимости параметра методики.
    /// </summary>
    public DbSet<MethodologyParameterTriggerEntity> Methodology_ParameterRelationTrigger { get; set; }
    
    /// <summary>
    /// Идентифицирующие строчки для параметров.
    /// </summary>
    public DbSet<MethodologyParameterValueRelationEntity> Methodology_ParameterValue { get; set; }
    
    /// <summary>
    /// Идентифицирующие строчки для параметров.
    /// </summary>
    public DbSet<MethodologyParameterValueIdentify> Methodology_ParameterValueIdentify { get; set; }
    
    /// <summary>
    /// Таблица связей методики и показателя.
    /// </summary>
    public DbSet<MethodologyResultParameterRelation> Methodology_ResultParameterRelation { get; set; }
    
    /// <summary>
    /// Настройки методики пользователя.
    /// </summary>
    public DbSet<MethodologyUserSettingsEntity> Methodology_UserSettings { get; set; }
    
    /// <summary>
    /// Методология группы заявок.
    /// </summary>
    public DbSet<MethodologyBundleEntity> MethodologyBundle { get; set; }
    
    /// <summary>
    /// Методология элемента группы заявок.
    /// </summary>
    public DbSet<MethodologyBundleItemEntity> MethodologyBundleItem { get; set; }
    
    /// <summary>
    /// Связь элемента группы заявок с методологией.
    /// </summary>
    public DbSet<MethodologyBundleItemLinkEntity> MethodologyBundleItemLink { get; set; }
    
    /// <summary>
    /// Entity файла методики.
    /// </summary>
    public DbSet<MethodologyFileEntity> MethodologyFile { get; set; }
    
    /// <summary>
    /// Зависимость видимости файлов методики от значений параметров заявки.
    /// </summary>
    public DbSet<MethodologyFileParameterValueRelationEntity> MethodologyFile_ParameterValueRelation { get; set; }
    
    /// <summary>
    /// Настройки видимости параметра методики от продукта.
    /// </summary>
    public DbSet<MethodologyParameterProductVisibilityRelation> MethodologyParameterProductVisibilityRelation { get; set; }
    
    /// <summary>
    /// Группы параметров в методике.
    /// </summary>
    public DbSet<MethodologyParametersGroup> MethodologyParametersGroups { get; set; }
    
    /// <summary>
    /// Связи методик с парсерами.
    /// </summary>
    public DbSet<MethodologyParserRelation> MethodologyParserRelations { get; set; }
    
    /// <summary>
    /// Связь элемента парсинга и валидатора данных.
    /// </summary>
    public DbSet<MethodologyParsingItem_ParsedResultsValidatorRelation> MethodologyParsingItem_ParsedResultsValidatorRelations { get; set; }
    
    /// <summary>
    /// Связь элемента парсинга и показателя.
    /// </summary>
    public DbSet<MethodologyParsingItem_ResultParameterRelation> MethodologyParsingItem_ResultParameterRelations { get; set; }
    
    /// <summary>
    /// Элемент парсинга стратегии обработки файлов методики.
    /// </summary>
    public DbSet<MethodologyParsingItemEntity> MethodologyParsingItemEntities { get; set; }
    
    /// <summary>
    /// Конфиг обработки файлов результатов по методике.
    /// </summary>
    public DbSet<MethodologyParsingStrategyEntity> MethodologyParsingStrategyEntities { get; set; }
    
    /// <summary>
    /// Связь методики и блока отчета.
    /// </summary>
    public DbSet<Methodology_ReportPartRelation> MethodologyReportPartRelations { get; set; }
    
    /// <summary>
    /// Сценарий тестирования для методики.
    /// </summary>
    public DbSet<MethodologyScenarioEntity> MethodologyScenario { get; set; }
    
    /// <summary>
    /// Значение параметра заявки для сценария тестирования.
    /// </summary>
    public DbSet<MethodologyScenario_RequestParameterValueRelation> MethodologyScenario_RequestParameterValueRelation { get; set; }
    
    /// <summary>
    /// Схема стенда.
    /// </summary>
    public DbSet<MethodologyStandEntity> MethodologyStand { get; set; }
    
    /// <summary>
    /// Связь между схемой стенда и файлом методики.
    /// </summary>
    public DbSet<MethodologyStand_MethodologyFileRelation> MethodologyStand_MethodologyFileRelation { get; set; }
    
    /// <summary>
    /// Связь между схемой стенда и тестовым окружением.
    /// </summary>
    public DbSet<MethodologyStand_TestEnvironmentRelation> MethodologyStand_TestEnvironmentRelation { get; set; }
    
    /// <summary>
    /// Схема стенда методики.
    /// </summary>
    public DbSet<MethodologyStandSchemeEntity> MethodologyStandSchemeEntities { get; set; }
    
    /// <summary>
    /// Триггер схемы стенда методики.
    /// </summary>
    public DbSet<MethodologyStandSchemeParameterValueRelation> MethodologyStandSchemeParameterValueRelations { get; set; }
    
    /// <summary>
    /// Триггер, описывающий когда должна применяться схема.
    /// </summary>
    public DbSet<MethodologyStandTrigger> MethodologyStandTrigger { get; set; }
    
    /// <summary>
    /// Связь между триггером стенда и значением параметра.
    /// </summary>
    public DbSet<MethodologyStandTrigger_ParameterValue> MethodologyStandTrigger_ParameterValue { get; set; }
    
    /// <summary>
    /// Объект тестовое окружение.
    /// </summary>
    public DbSet<ObjectTestEnvironmentEntity> ObjectTestEnvironment { get; set; }
    
    /// <summary>
    /// Офис.
    /// </summary>
    public DbSet<OfficeEntity> Office { get; set; }
    
    /// <summary>
    /// Операционная система.
    /// </summary>
    public DbSet<OperationSystemEntity> OperationSystem { get; set; }
    
    /// <summary>
    /// Связь операционнонй системы со значениями по умолчанию.
    /// </summary>
    public DbSet<OperationSystemDefaultParameterValueRelation> OperationSystem_DefaultParameterValueRelation { get; set; }
    
    /// <summary>
    /// Связь ОС и значения параметра.
    /// </summary>
    public DbSet<OperationSystemParameterValueRelation> OperationSystem_ParameterValueRelation { get; set; }
    
    /// <summary>
    /// Информация о билде на сервисе release.
    /// </summary>
    public DbSet<OvaBuildEntity> OvaBuild { get; set; }
    
    /// <summary>
    /// Дистрибутив на доске релизов OVA.
    /// </summary>
    public DbSet<OvaDistributionEntity> OvaDistribution { get; set; }
    
    /// <summary>
    /// Параметр.
    /// </summary>
    public DbSet<ParameterEntity> Parameter { get; set; }
    
    /// <summary>
    /// Перевод для параметра.
    /// </summary>
    public DbSet<ParameterTranslationEntity> Parameter_Translation { get; set; }
    
    /// <summary>
    /// Отношение скрывающихся параметров.
    /// </summary>
    public DbSet<ParameterShadowedValueEntity> ParameterShadowedValue { get; set; }
    
    /// <summary>
    /// Значение параметра.
    /// </summary>
    public DbSet<ParameterValueEntity> ParameterValue { get; set; }
    
    /// <summary>
    /// Перевод для значения параметра.
    /// </summary>
    public DbSet<ParameterValueTranslationEntity> ParameterValue_Translation { get; set; }
    
    /// <summary>
    /// Валидатор полученных из файла данных.
    /// </summary>
    public DbSet<ParsedResultsValidatorEntity> ParsedResultsValidatorEntities { get; set; }
    
    /// <summary>
    /// Продукт.
    /// </summary>
    public DbSet<ProductEntity> Product { get; set; }
    
    /// <summary>
    /// Связь методики и параметра.
    /// </summary>
    public DbSet<ProductFeatureSetRelationEntity> Product_FeatureSetRelation { get; set; }
    
    /// <summary>
    /// Связь продукта с ключевыми для него параметрами в отчете по сборкам.
    /// </summary>
    public DbSet<ProductBuildReportParameterRelation> ProductBuildReportParameterRelations { get; set; }
    
    /// <summary>
    /// Entity файла продукта.
    /// </summary>
    public DbSet<ProductFileEntity> ProductFile { get; set; }
    
    /// <summary>
    /// Группа продуктов.
    /// </summary>
    public DbSet<ProductGroupEntity> ProductGroup { get; set; }
    
    /// <summary>
    /// Связь продукта с дистрибутивами.
    /// </summary>
    public DbSet<ProductOvaDistributionRelation> ProductOvaDistributionRelations { get; set; }
    
    /// <summary>
    /// Переводы для продукта.
    /// </summary>
    public DbSet<ProductTranslationEntity> ProductTranslation { get; set; }
    
    /// <summary>
    /// Версия продукта.
    /// </summary>
    public DbSet<ProductVersionEntity> ProductVersion { get; set; }
    
    /// <summary>
    /// Информация об актуальной сборке версии продукта.
    /// </summary>
    public DbSet<ProductVersion_ActualBuildInfoEntity> ProductVersion_ActualBuild { get; set; }
    
    /// <summary>
    /// Результаты тестирования по методикам производительности для сборки версии продукта.
    /// </summary>
    public DbSet<ProductVersion_Build_Perf_ResultsEntity> ProductVersion_Build_Perf_Result { get; set; }
    
    /// <summary>
    /// Хеши конфигураций для замеров.
    /// </summary>
    public DbSet<ProductVersion_Build_ResultHashEntity> ProductVersion_Build_ResultHash { get; set; }
    
    /// <summary>
    /// Информация о сборке продукта, полученная из сервиса сборок ОВА или базы данных VPA.
    /// </summary>
    public DbSet<CompositeBuildInfoEntity> ProductVersion_CompositeBuild { get; set; }
    
    /// <summary>
    /// Связь версии продукта со значениями по умолчанию.
    /// </summary>
    public DbSet<ProductVersionDefaultParameterValueRelation> ProductVersion_DefaultParameterValueRelation { get; set; }
    
    /// <summary>
    /// Связь версии продукта и пакета методик тестирования.
    /// </summary>
    public DbSet<ProductVersionMethodologyBundleRelation> ProductVersion_MethodologyBundleRelation { get; set; }
    
    /// <summary>
    /// Связь версии продукта и методики тестирования.
    /// </summary>
    public DbSet<ProductVersionMethodologyRelation> ProductVersion_MethodologyRelation { get; set; }
    
    /// <summary>
    /// Связь версии продукта и операционной системы.
    /// </summary>
    public DbSet<ProductVersionOperationSystemRelation> ProductVersion_OperationSystemRelation { get; set; }
    
    /// <summary>
    /// Связь версии продукта и значения параметра.
    /// </summary>
    public DbSet<ProductVersionParameterValueRelation> ProductVersion_ParameterValueRelation { get; set; }
    
    /// <summary>
    /// Целевой показатель версии продукта.
    /// </summary>
    public DbSet<ProductVersionTargetEntity> ProductVersionTarget { get; set; }
    
    /// <summary>
    /// Связь продукта с файлом целевых показателей.
    /// </summary>
    public DbSet<ProductVersionTargetFileRelation> ProductVersionTargetFileRelations { get; set; }
    
    /// <summary>
    /// Набор целевой показателей для номера версии продуктов.
    /// </summary>
    public DbSet<ProductVersionTargetSetEntity> ProductVersionTargetSet { get; set; }
    
    /// <summary>
    /// Проект.
    /// </summary>
    public DbSet<ProjectEntity> Project { get; set; }
    
    /// <summary>
    /// Менеджер проекта.
    /// </summary>
    public DbSet<ProjectManagerEntity> ProjectManager { get; set; }
    
    /// <summary>
    /// Данные об убитой когда-то заявке.
    /// </summary>
    public DbSet<RemovedRequestEntity> RemovedRequests { get; set; }
    
    /// <summary>
    /// Блок отчета.
    /// </summary>
    public DbSet<ProductEntity> ReportPartEntities { get; set; }
    
    /// <summary>
    /// Заявка на нагрузочное тестирование.
    /// </summary>
    public DbSet<RequestEntity> Request { get; set; }
    
    /// <summary>
    /// Связь заявки и ключевого слова.
    /// </summary>
    public DbSet<RequestKeyWordRelation> Request_KeyWordRelation { get; set; }
    
    /// <summary>
    /// Связь заявки и значения параметра.
    /// </summary>
    public DbSet<RequestParameterValueRelation> Request_ParameterValueRelation { get; set; }
    
    /// <summary>
    /// Группа заявок.
    /// </summary>
    public DbSet<RequestBundleEntity> RequestBundle { get; set; }
    
    /// <summary>
    /// Элемент группы заявок.
    /// </summary>
    public DbSet<RequestBundleItemEntity> RequestBundleItem { get; set; }
    
    /// <summary>
    /// Заявка на нагрузочное тестирование.
    /// </summary>
    public DbSet<RequestBundleStorageFileEntity> RequestBundleStorageFile { get; set; }
    
    /// <summary>
    /// История изменения заявки.
    /// </summary>
    public DbSet<RequestChangesHistoryEntity> RequestChangesHistory { get; set; }
    
    /// <summary>
    /// Файл, связанный с заявкой.
    /// </summary>
    public DbSet<RequestFileEntity> RequestFile { get; set; }
    
    /// <summary>
    /// Заявка на нагрузочное тестирование.
    /// </summary>
    public DbSet<RequestReportFileEntity> RequestReportFile { get; set; }
    
    /// <summary>
    /// Результирующие данные по заявке.
    /// </summary>
    public DbSet<RequestResultDataEntity> RequestResultData { get; set; }
    
    /// <summary>
    /// Ревью заявки.
    /// </summary>
    public DbSet<RequestReviewEntity> RequestReview { get; set; }
    
    /// <summary>
    /// Сущность теста заявки.
    /// </summary>
    public DbSet<RequestTestEntity> RequestTest { get; set; }
    
    /// <summary>
    /// Связь теста заявки и значения параметра.
    /// </summary>
    public DbSet<RequestTestParameterValueRelation> RequestTest_ParameterValueRelation { get; set; }
    
    /// <summary>
    /// Результирующие данные по тесту.
    /// </summary>
    public DbSet<RequestTestResultDataEntity> RequestTestResultData { get; set; }
    
    /// <summary>
    /// Связь результатов тестирования и параметров.
    /// </summary>
    public DbSet<RequestTestResultData_ParameterValueRelation> RequestTestResultData_ParameterValueRelation { get; set; }
    
    /// <summary>
    /// Показатель методики.
    /// </summary>
    public DbSet<ResultParameterEntity> ResultParameter { get; set; }
    
    /// <summary>
    /// Группа показателей.
    /// </summary>
    public DbSet<ResultParameterGroupEntity> ResultParameterGroup { get; set; }
    
    /// <summary>
    /// Перевод для показателя.
    /// </summary>
    public DbSet<ResultParameterTranslationEntity> ResultParameterTranslation { get; set; }
    
    /// <summary>
    /// Данные аналитических отчетов Sies.
    /// </summary>
    public DbSet<SiesAnalyticsReportEntity> SiesReportEntities { get; set; }
    
    /// <summary>
    /// Схема стенда.
    /// </summary>
    public DbSet<StandSchemeEntity> StandSchemeEntities { get; set; }
    
    /// <summary>
    /// Связь схемы стенда с объектом схемы стенда.
    /// </summary>
    public DbSet<StandSchemeTestObjectRelation> StandSchemeTestObjectRelations { get; set; }
    
    /// <summary>
    /// Файл хранилища.
    /// </summary>
    public DbSet<StorageFileEntity> StorageFile { get; set; }
    
    /// <summary>
    /// Целевой показатель.
    /// </summary>
    public DbSet<TargetEntity> Target { get; set; }
    
    /// <summary>
    /// Цель.
    /// TODO: Rename to Target.
    /// </summary>
    public DbSet<TargetNewEntity> TargetNew { get; set; }
    
    /// <summary>
    /// Строка справочника целевых значений.
    /// </summary>
    public DbSet<TargetRowEntity> TargetRow { get; set; }
    
    /// <summary>
    /// Шаблонный тест для методики.
    /// </summary>
    public DbSet<TemplateTestEntity> TemplateTest { get; set; }
    
    /// <summary>
    /// Связь Шаблонный тест - значение параметра.
    /// </summary>
    public DbSet<TemplateTestParameterValueRelationEntity> TemplateTest_ParameterValue { get; set; }
    
    /// <summary>
    /// Тестовое окружение.
    /// </summary>
    public DbSet<TestEnvironmentEntity> TestEnvironment { get; set; }
    
    /// <summary>
    /// Связь тестового окружения и объекта тестового окружения.
    /// </summary>
    public DbSet<TestEnvironmentObjectTestEnvironmentRelation> TestEnvironment_ObjectTestEnvironmentRelation { get; set; }
    
    /// <summary>
    /// Объект схемы стенда.
    /// </summary>
    public DbSet<TestObjectEntity> TestObjectEntities { get; set; }
    
    /// <summary>
    ///     Алгоритм расчёта теоретического максимума.
    /// </summary>
    public DbSet<TestEnvironmentTheoreticalMaximumEntity> TheoreticalMaximum_TestEnvironment { get; set; }
    
    /// <summary>
    ///     Алгоритм расчёта теоретического максимума.
    /// </summary>
    public DbSet<TheoreticalMaximumAlgorithmEntity> TheoreticalMaximumAlgorithm { get; set; }
    
    /// <summary>
    /// Перевод.
    /// </summary>
    public DbSet<TranslationEntity> Translation { get; set; }
    
    /// <summary>
    /// Связь сущностей и переводов.
    /// </summary>
    public DbSet<TranslationRelationEntity> TranslationRelation { get; set; }
    
    /// <summary>
    /// Пользователь системы.
    /// </summary>
    public DbSet<UserEntity> User { get; set; }
    
    /// <summary>
    /// Связь пользоватеелй и проектов.
    /// </summary>
    public DbSet<UserProjectRelation> User_ProjectRelation { get; set; }
    
    /// <summary>
    /// Связь пользователя с избранной сборкой.
    /// </summary>
    public DbSet<UserFavoriteBuildRelation> UserFavoriteBuildRelations { get; set; }
    
    /// <summary>
    /// Связь пользователя с избранной группой продуктов.
    /// </summary>
    public DbSet<UserFavoriteProductGroupRelation> UserFavoriteProductGroupRelations { get; set; }
    
    /// <summary>
    /// Связь пользователя с избранным продуктом.
    /// </summary>
    public DbSet<UserFavoriteProductRelation> UserFavoriteProductRelations { get; set; }
    
    /// <summary>
    /// Связб пользователя с избранной версией продукта.
    /// </summary>
    public DbSet<UserFavoriteProductVersionRelation> UserFavoriteProductVersionRelations { get; set; }
    
    /// <summary>
    /// Виртуальное исполнение.
    /// </summary>
    public DbSet<VirtualPlatformEntity> VirtualPlatformEntities { get; set; }
    
    /// <summary>
    /// Связь виртуального исполнения и значения параметра.
    /// </summary>
    public DbSet<VirtualPlatformParameterValueRelation> VirtualPlatformParameterValueRelations { get; set; }
}