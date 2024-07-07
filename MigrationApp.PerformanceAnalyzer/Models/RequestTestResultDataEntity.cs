using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Результирующие данные по тесту.
/// </summary>
[Table("RequestTestResultData")]
public class RequestTestResultDataEntity : EntityBase
{
    /// <summary>
    /// Файл собственной персоной.
    /// </summary>
    public virtual StorageFileEntity File { get; set; }

    /// <summary>
    /// Идентификатор файла в хранилище.
    /// </summary>
    [ForeignKey("File")]
    public Guid FileId { get; set; }

    /// <summary>
    /// Значения итерируемых параметров результата.
    /// </summary>
    public virtual ICollection<RequestTestResultData_ParameterValueRelation> ExtraParameterValues { get; set; }

    /// <summary>
    /// Значение итерируемого параметра.
    /// TODO: перенести в IterParameterValues.
    /// </summary>
    public virtual ParameterValueEntity IterParameterValue { get; set; }

    /// <summary>
    /// Идентификатор значения итерируемого параметра.
    /// </summary>
    [ForeignKey("IterParameterValue")]
    public Guid IterParameterValueId { get; set; }

    /// <summary>
    /// Дополнительные результаты выполнения теста.
    /// TODO: убрать из этого поля все параметры. Перенести в соответствующие поля.
    /// </summary>
    public string ParsedDataJson { get; set; }

    /// <summary>
    /// Результат выполнения теста.
    /// </summary>
    public double RawDataResult { get; set; }

    /// <summary>
    /// Данные о тесте заявки.
    /// </summary>
    public virtual RequestTestEntity RequestTest { get; set; }

    /// <summary>
    /// Идентификатор теста заявки.
    /// </summary>
    [ForeignKey("RequestTest")]
    public Guid RequestTestId { get; set; }

    /// <summary>
    /// Показатель, для которого проводился тест.
    /// </summary>
    public virtual ResultParameterEntity ResultParameter { get; set; }

    /// <summary>
    /// Идентификатор показателя, к которому привязан файл.
    /// </summary>
    [ForeignKey("ResultParameter")]
    public Guid ResultParameterId { get; set; }

    /// <summary>
    /// Строковой результат выполнения теста.
    /// </summary>
    public string StringDataResult { get; set; }

    /// <summary>
    /// Параметры тестирования, которые могут быть дополнительно получены при работе парсера.
    /// TODO: Переименовать в "дополнительные параметры". Хранить то, чего нет в тесте, в JSON. Например, версия прошивки из файла результатов.
    /// </summary>
    public string TestParameters { get; set; }

    /// <summary>
    /// Комментарий в ячейку.
    /// </summary>
    public string ShortComment { get; set; }

    /// <summary>
    /// Комментарий в выводы.
    /// </summary>
    public string Comment { get; set; }
}