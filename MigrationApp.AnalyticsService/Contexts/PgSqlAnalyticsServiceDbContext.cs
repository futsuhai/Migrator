using Microsoft.EntityFrameworkCore;
using MigrationApp.AnalyticsService.Models;

namespace MigrationApp.AnalyticsService.Contexts;

/// <summary>
/// Postgre контекст AnalyticsService.
/// </summary>
public class PgSqlAnalyticsServiceDbContext : DbContext
{
    public PgSqlAnalyticsServiceDbContext(DbContextOptions<PgSqlAnalyticsServiceDbContext> options)
        : base(options) { }
    
    /// <summary>
    /// Значения параметров.
    /// </summary>
    public DbSet<ParameterValueEntity> ParameterValues { get; set; }

    /// <summary>
    /// Заявки.
    /// </summary>
    public DbSet<RequestEntity> Requests { get; set; }

    /// <summary>
    /// Результаты.
    /// </summary>
    public DbSet<ResultEntity> Results { get; set; }

    /// <summary>
    /// Целевые значения.
    /// </summary>
    public DbSet<TargetEntity> Targets { get; set; }
    
    /// <summary>
    /// Отношение результатов с параметрами.
    /// </summary>
    public DbSet<Result_ParameterValueRelationEntity> Result_ParameterValueRelationEntity { get; set; }
}