namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Данные об убитой когда-то заявке.
/// </summary>
public class RemovedRequestEntity : EntityBase
{
    /// <summary>
    /// Короткий идентификатор.
    /// </summary>
    public int ShortId { get; set; }

    /// <summary>
    /// Полное название продукта (название, версия, номер сборки).
    /// </summary>
    public string ProductFullName { get; set; }

    /// <summary>
    /// Код методики.
    /// </summary>
    public string TestCode { get; set; }

    /// <summary>
    /// Комментарий.
    /// </summary>
    public string Comment { get; set; }

    /// <summary>
    /// Дата удаления.
    /// </summary>
    public DateTime RemovalDate { get; set; }

    /// <summary>
    /// Имя пользователя, удалившего заявку.
    /// </summary>
    public string RemovedByUser { get; set; }
}