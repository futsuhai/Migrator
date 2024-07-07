using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MigrationApp.Common;
using MigrationApp.Common.Extensions;

namespace MigrationApp.Start.Migrator;

/// <summary>
/// Класс для выполнения миграции MS SQL таблицы в Postgre.
/// </summary>
public class Migrator(ILogger<Migrator> logger)
{
    // Количество записей для миграции за один раз.
    private const int RecordPerTime = 10000;

    /// <summary>
    /// Метод для миграции таблицы из MS SQL в Postgre
    /// </summary>
    /// <param name="msSqlContext">MS SQL контекст.</param>
    /// <param name="pgSqlContext">Postgre контекст.</param>
    /// <param name="dbSet">Таблица для миграции.</param>
    /// <typeparam name="TEntity">Тип сущности таблицы.</typeparam>
    public async Task MigrateDataAsync<TEntity>(DbContext msSqlContext, DbContext pgSqlContext, DbSet<TEntity> dbSet)
        where TEntity : class
    {
        // Получение MS SQL таблицы из которой будет производиться миграция.
        var msTableProperty = msSqlContext.Set<TEntity>();

        // Получение Postgre таблицы для миграции.
        var pgTableProperty = pgSqlContext.Set<TEntity>();
        
        var tableName = (pgSqlContext.Model.FindEntityType(typeof(TEntity)) ?? throw new InvalidOperationException()).GetSchemaQualifiedTableName();

        // Получение количества записей в MS SQL таблице.
        var msCount = await msTableProperty.CountAsync();

        // Получение количества записей в Postgre таблице.
        var pgCount = await pgTableProperty.CountAsync();
        
        // Логгирование информации о таблице и количестве записей в начале метода
        logger.LogInformation($"Начало миграции таблицы '{tableName}' с {msCount} записями.");

        // Если количество записей в таблицах равно, не выполняем никаких действий.
        if (msCount == pgCount)
        {
            logger.LogInformation($"Количество записей в таблицах '{tableName}' равно, миграция не требуется.");
            return;
        }
        
        // Если количество записей в таблицах различается и в Postgre таблице есть записи, удаляем все записи из Postgre таблицы.
        if (msCount != pgCount && pgCount > 0)
        {
            if (tableName != null) pgSqlContext.Database.ExecuteSqlRaw("DELETE FROM {0}", tableName);
            logger.LogInformation($"Все записи из таблицы '{tableName}' были удалены перед миграцией.");
        }

        var skip = 0;
        
        // Запуск таймера для измерения времени миграции
        var dateStart = DateTime.Now;

        while (true)
        {
            // Получение пачки записей из таблицы.
            var msEntities = await msTableProperty
                .AsNoTracking()
                .Skip(skip)
                .Take(RecordPerTime)
                .ToListAsync();

            // Если записей нет, выходим из цикла.
            if (msEntities.Count == 0)
            {
                break;
            }

            // Добавление записей в таблицу.
            pgTableProperty.AddRange(msEntities);

            // Преобразование даты в формат UTC.
            pgSqlContext.ConvertDateTimeToUtc();

            // Сохранение изменений в таблице.
            await pgSqlContext.SaveChangesAsync();

            skip += RecordPerTime;
            GC.Collect();
        }
        
        var dateEnd = DateTime.Now;
        
        // Логгирование времени выполнения миграции и сообщение об успешном завершении
        logger.LogInformation($"Миграция таблицы '{tableName}' с {msCount} записями завершена за {(dateEnd - dateStart).Minutes} минут.");
    }
}