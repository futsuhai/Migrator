namespace MigrationApp.Common.Models;

/// <summary>
/// Общие настройки.
/// </summary>
public static class Selected
{
    private static readonly object Lock = new object();

    /// <summary>
    /// Язык.
    /// </summary>
    public static string Language
    {
        get
        {
            lock (Lock)
            {
                string language = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;
                return language;
            }
        }
    }
}