using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Связь между схемой стенда и файлом методики.
/// </summary>
[Table("MethodologyStand_MethodologyFileRelation")]
public class MethodologyStand_MethodologyFileRelation : EntityBase
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
    /// Схема стенда.
    /// </summary>
    public virtual MethodologyStandEntity MethodologyStand { get; set; }

    /// <summary>
    /// Идентификатор схемы стенда.
    /// </summary>
    [ForeignKey("MethodologyStand")]
    public Guid MethodologyStandId { get; set; }
}