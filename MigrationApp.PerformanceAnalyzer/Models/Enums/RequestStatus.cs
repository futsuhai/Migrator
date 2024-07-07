namespace MigrationApp.PerformanceAnalyzer.Models.Enums;

    /// <summary>
    /// Статусы заявки.
    /// </summary>
    public enum RequestStatus
    {
        /// <summary>
        /// Создана.
        /// </summary>
        Proposed = 0,

        /// <summary>
        /// Запланирована.
        /// </summary>
        Planned = 1,

        /// <summary>
        /// Утверждена.
        /// </summary>
        Approved = 2,

        /// <summary>
        /// Идет тестирование.
        /// </summary>
        Active = 3,

        /// <summary>
        /// Тесты проведены.
        /// </summary>
        TestsCompleted = 4,

        /// <summary>
        /// Сформирован отчет.
        /// </summary>
        ReportCreated = 5,

        /// <summary>
        /// Передано на ревью.
        /// </summary>
        ReviewRequested = 6,

        /// <summary>
        /// Принято экспертом.
        /// </summary>
        ReviewApproved = 7,

        /// <summary>
        /// Проведено ревью.
        /// </summary>
        ReviewCompleted = 8,

        /// <summary>
        /// Отменена.
        /// </summary>
        Canceled = 9,

        /// <summary>
        /// Закрыта.
        /// </summary>
        Closed = 10,

        /// <summary>
        /// Генерируется отчет.
        /// </summary>
        GeneratingReport = 11,
    }