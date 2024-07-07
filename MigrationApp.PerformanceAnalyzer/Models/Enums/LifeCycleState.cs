﻿namespace MigrationApp.PerformanceAnalyzer.Models.Enums;

/// <summary>
/// Состояние сборки.
/// </summary>
public enum LifeCycleState
{
    /// <summary>
    /// Собрана.
    /// </summary>
    Builded = 0,

    /// <summary>
    /// Релиз-кандидат.
    /// </summary>
    ReleaseCandidate = 1,

    /// <summary>
    /// Релиз.
    /// </summary>
    Release = 2,

    /// <summary>
    /// Сертифицирована
    /// </summary>
    Certified = 3,

    /// <summary>
    /// Готова к архивации.
    /// </summary>
    ReadyForArchiving = 4,

    /// <summary>
    /// Архивная.
    /// </summary>
    Archival = 5,
}