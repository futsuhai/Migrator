using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace MigrationApp.Common.Extensions;

/// <summary>
/// Расширения DbContext для конвертации дат.
/// </summary>
public static class DbContextExtensions
{
    /// <summary>
    /// Преобразование свойств DateTime в формат UTC.
    /// </summary>
    /// <param name="context">Контекст базы данных.</param>
    public static void ConvertDateTimeToUtc(this DbContext context)
    {
        // Получение всех добавленных или измененных сущностей.
        var entries = context.ChangeTracker.Entries()
            .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);

        foreach (var entry in entries)
        {
            // Преобразование свойств DateTime в формат UTC.
            ConvertDateTimePropertiesToUtc(entry.Entity);
        }
    }

    /// <summary>
    /// Преобразование свойств DateTime в формат UTC для объекта.
    /// </summary>
    /// <param name="obj">Объект.</param>
    private static void ConvertDateTimePropertiesToUtc(object obj)
    {
        // Получение всех свойств DateTime.
        var properties = obj.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
            .Where(p => p.PropertyType == typeof(DateTime) || p.PropertyType == typeof(DateTime?));

        foreach (var property in properties)
        {
            // Получение значения свойства.
            var value = property.GetValue(obj);

            if (value is DateTime dateTime)
            {
                // Преобразование значения в формат UTC.
                property.SetValue(obj, dateTime.ToUniversalTime());
            }
            else if (value is DateTime? && ((DateTime?)value).HasValue)
            {
                // Преобразование значения в формат UTC.
                property.SetValue(obj, ((DateTime?)value).Value.ToUniversalTime());

            }
        }
    }
}
