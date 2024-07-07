using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Зависимость видимости файлов методики от значений параметров заявки.
/// </summary>
[Table("MethodologyFile_ParameterValueRelation")]
public class MethodologyFileParameterValueRelationEntity : EntityBase
{
    /// <summary>
    /// Файл методики.
    /// </summary>
    public virtual MethodologyFileEntity MethodologyFile { get; set; }

    /// <summary>
    /// Идентификатор файла методики.
    /// </summary>
    [ForeignKey("MethodologyFile")]
    public Guid MethodologyFileId { get; set; }

    /// <summary>
    /// Значение параметра, при выборе которого файл показывается.
    /// </summary>
    public virtual ParameterValueEntity ParameterValue { get; set; }

    /// <summary>
    /// Идентификатор значения параметра, при выборе которого файл показывается.
    /// </summary>
    [ForeignKey("ParameterValue")]
    public Guid ParameterValueId { get; set; }
}