using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MigrationApp.AnalyticsService.Contexts;
using MigrationApp.PerformanceAnalyzer.Contexts;
using MigrationApp.SearchService.Contexts;

namespace MigrationApp.Start;

public static class Program
{
    public static async Task Main(string[] args)
    {
        var host = CreateHostBuilder(args).Build();
        
        // Создание экземпляра ILogger<Migrator>
        var logger = LoggerFactory.Create(builder =>
        {
            builder
                .AddFilter("Microsoft", LogLevel.Warning)
                .AddFilter("System", LogLevel.Warning)
                .AddFilter("LoggingConsoleApp.Program", LogLevel.Debug)
                .AddConsole();
        }).CreateLogger<Migrator.Migrator>();
        
        // Экземпляр класса, выполняющего миграцию таблиц.
        Migrator.Migrator migrator = new(logger);
        
        // Миграция AnalyticsService.
        using (var scope = host.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            
            // Контексты AnalyticsService.
            var msSqlAnalyticsServiceDbContext = services.GetRequiredService<MsSqlAnalyticsServiceDbContext>();
            var pgSqlAnalyticsServiceDbContext = services.GetRequiredService<PgSqlAnalyticsServiceDbContext>();
            
            var dateStart = DateTime.Now;
            logger.LogInformation($"Началась миграция базы AnalyticsService. Количество таблиц: " +
                                  $"{msSqlAnalyticsServiceDbContext.Model.GetEntityTypes().Count()}");

            // Вызываем миграцию
            await MigrateAnalyticsService(msSqlAnalyticsServiceDbContext, pgSqlAnalyticsServiceDbContext, migrator);
            
            // Логгирование времени выполнения
            var dateEnd = DateTime.Now;
            logger.LogInformation($"Миграция базы PerformanceAnalyzer завершена за {(dateEnd - dateStart).TotalMinutes} минут.");
        }
        
        // Миграция SearchService.
        using (var scope = host.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            
            // Контексты SearchService.
            var msSqlSearchServiceDbContext = services.GetRequiredService<MsSqlSearchServiceDbContext>();
            var pgSqlSearchServiceDbContext = services.GetRequiredService<PgSqlSearchServiceDbContext>();
            
            var dateStart = DateTime.Now;
            logger.LogInformation($"Началась миграция базы SearchService. Количество таблиц: " +
                                  $"{msSqlSearchServiceDbContext.Model.GetEntityTypes().Count()}");

            // Вызываем миграцию
            await MigrateSearchService(msSqlSearchServiceDbContext, pgSqlSearchServiceDbContext, migrator);
            
            // Логгирование времени выполнения
            var dateEnd = DateTime.Now;
            logger.LogInformation($"Миграция базы PerformanceAnalyzer завершена за {(dateEnd - dateStart).TotalMinutes} минут.");
        }
        
        // Миграция PerformanceAnalyzer.
        using (var scope = host.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            
            // Контексты PerformanceAnalyzer.
            var msSqlPerformanceAnalyzerDbContext = services.GetRequiredService<MsSqlPerformanceAnalyzerDbContext>();
            var pgSqlPerformanceAnalyzerDbContext = services.GetRequiredService<PgSqlPerformanceAnalyzerDbContext>();

            var dateStart = DateTime.Now;
            logger.LogInformation($"Началась миграция базы PerformanceAnalyzer. Количество таблиц: " +
                                  $"{msSqlPerformanceAnalyzerDbContext.Model.GetEntityTypes().Count()}");
            // Вызываем миграцию
            await MigratePerformanceAnalyzer(msSqlPerformanceAnalyzerDbContext, pgSqlPerformanceAnalyzerDbContext, migrator);
            
            // Логгирование времени выполнения
            var dateEnd = DateTime.Now;
            logger.LogInformation($"Миграция базы PerformanceAnalyzer завершена за {(dateEnd - dateStart).TotalMinutes} минут.");
        }
        
        await host.RunAsync();
    }
    
    /// <summary>
    /// Метод для миграции базы AnalyticsService.
    /// </summary>
    /// <param name="msSqlContext">MS SQL контекст.</param>
    /// <param name="pgSqlContext">Postgre контекст.</param>
    /// <param name="migrator">Выполняет миграцию.</param>
    private static async Task MigrateAnalyticsService(
        MsSqlAnalyticsServiceDbContext msSqlContext,
        PgSqlAnalyticsServiceDbContext pgSqlContext,
        Migrator.Migrator migrator)
    {
        // Миграция таблиц
        await migrator.MigrateDataAsync(msSqlContext, pgSqlContext, msSqlContext.Result_ParameterValueRelationEntity);
        await migrator.MigrateDataAsync(msSqlContext, pgSqlContext, msSqlContext.ParameterValues);
        await migrator.MigrateDataAsync(msSqlContext, pgSqlContext, msSqlContext.Targets);
        await migrator.MigrateDataAsync(msSqlContext, pgSqlContext, msSqlContext.Requests);
        await migrator.MigrateDataAsync(msSqlContext, pgSqlContext, msSqlContext.Results);
    }
    
    /// <summary>
    /// Метод для миграции базы SearchService.
    /// </summary>
    /// <param name="msSqlContext">MS SQL контекст.</param>
    /// <param name="pgSqlContext">Postgre контекст.</param>
    /// <param name="migrator">Выполняет миграцию.</param>
    private static async Task MigrateSearchService(
        MsSqlSearchServiceDbContext msSqlContext,
        PgSqlSearchServiceDbContext pgSqlContext,
        Migrator.Migrator migrator)
    {
        // Миграция таблиц
        await migrator.MigrateDataAsync(msSqlContext, pgSqlContext, msSqlContext.Methodologies);
        await migrator.MigrateDataAsync(msSqlContext, pgSqlContext, msSqlContext.Products);
        await migrator.MigrateDataAsync(msSqlContext, pgSqlContext, msSqlContext.MethodologyLocationRelations);
        await migrator.MigrateDataAsync(msSqlContext, pgSqlContext, msSqlContext.MethodologyProductRelations);
    }
    
    /// <summary>
    /// Метод для миграции базы PerformanceAnalyzer.
    /// </summary>
    /// <param name="msSqlContext">MS SQL контекст.</param>
    /// <param name="pgSqlContext">Postgre контекст.</param>
    /// <param name="migrator">Выполняет миграцию.</param>
    private static async Task MigratePerformanceAnalyzer(
        MsSqlPerformanceAnalyzerDbContext msSqlContext,
        PgSqlPerformanceAnalyzerDbContext pgSqlContext,
        Migrator.Migrator migrator)
    {
        // Миграция таблиц
        await migrator.MigrateDataAsync(msSqlContext, pgSqlContext, msSqlContext.Build);
        await migrator.MigrateDataAsync(msSqlContext, pgSqlContext, msSqlContext.DataParser);
        await migrator.MigrateDataAsync(msSqlContext, pgSqlContext, msSqlContext.FeatureSet);
        await migrator.MigrateDataAsync(msSqlContext, pgSqlContext, msSqlContext.FeatureSwitchEntities);
        await migrator.MigrateDataAsync(msSqlContext, pgSqlContext, msSqlContext.FileParsingDataExtractorEntities);
        await migrator.MigrateDataAsync(msSqlContext, pgSqlContext, msSqlContext.GlobalSettings);
        await migrator.MigrateDataAsync(msSqlContext, pgSqlContext, msSqlContext.IntegralResultCalculatorEntities);
        await migrator.MigrateDataAsync(msSqlContext, pgSqlContext, msSqlContext.KeyWord);
        await migrator.MigrateDataAsync(msSqlContext, pgSqlContext, msSqlContext.MethodologyBundle);
        await migrator.MigrateDataAsync(msSqlContext, pgSqlContext, msSqlContext.MethodologyBundleItem);
        // Тут остальные таблицы PerformanceAnalyzer.
    }
    
    /// <summary>
    /// Метод создания экземпляра IHostBuilder.
    /// </summary>
    /// <param name="args">Аргументы командной строки.</param>
    /// <returns>Экземпляр IHostBuilder.</returns>
    private static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((hostingContext, configuration) =>
            {
                // Очистка существующих источников конфигурации.
                configuration.Sources.Clear();

                var env = hostingContext.HostingEnvironment;

                // Добавление JSON-файлов конфигурации.
                configuration
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                    .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);

                // Добавление конфигурации из переменных среды.
                configuration.AddEnvironmentVariables();
            })
            .ConfigureServices((hostContext, services) =>
            {
                var configuration = hostContext.Configuration;

                // Добавление контекста базы данных MS SQL для сервиса аналитики.
                services.AddDbContext<MsSqlAnalyticsServiceDbContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("MsSqlAnalyticsServiceConnection"),
                        sqlOptions => sqlOptions.CommandTimeout(30 * 60 * 60)));

                // Добавление контекста базы данных PostgreSQL для сервиса аналитики.
                services.AddDbContext<PgSqlAnalyticsServiceDbContext>(options =>
                    options.UseNpgsql(configuration.GetConnectionString("PgSqlAnalyticsServiceConnection"),
                        npgsqlOptions => npgsqlOptions.CommandTimeout(30 * 60 * 60)));

                // Добавление контекста базы данных MS SQL для сервиса поиска.
                services.AddDbContext<MsSqlSearchServiceDbContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("MsSqlSearchServiceConnection"),
                        sqlOptions => sqlOptions.CommandTimeout(30 * 60 * 60)));

                // Добавление контекста базы данных Postgre для сервиса поиска.
                services.AddDbContext<PgSqlSearchServiceDbContext>(options =>
                    options.UseNpgsql(configuration.GetConnectionString("PgSqlSearchServiceConnection"),
                        npgsqlOptions => npgsqlOptions.CommandTimeout(30 * 60 * 60)));
                
                // Добавление контекста базы данных MS SQL для основного проекта.
                services.AddDbContext<MsSqlPerformanceAnalyzerDbContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("MsSqlPerformanceAnalyzerConnection"),
                        sqlOptions => sqlOptions.CommandTimeout(30 * 60 * 60)));

                // Добавление контекста базы данных Postgre для основного проекта.
                services.AddDbContext<PgSqlPerformanceAnalyzerDbContext>(options =>
                    options.UseNpgsql(configuration.GetConnectionString("PgSqlPerformanceAnalyzerConnection"),
                        npgsqlOptions => npgsqlOptions.CommandTimeout(30 * 60 * 60)));
            });
}