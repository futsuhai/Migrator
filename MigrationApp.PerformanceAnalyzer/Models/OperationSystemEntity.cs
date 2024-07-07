using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Операционная система.
/// </summary>
[Table("OperationSystem")]
public class OperationSystemEntity : EntityBase
{
    /// <summary>
    /// Название ОС.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Связи ОС и АП.
    /// </summary>
    public virtual ICollection<HardwarePlatformOperationSystemRelation> HardwarePlatformRelations { get; set; }

    /// <summary>
    /// Связи ОС и параметров.
    /// </summary>
    public virtual ICollection<OperationSystemParameterValueRelation> ParameterValueRelations { get; set; }

    /// <summary>
    /// Связи ОС и версий продуктов.
    /// </summary>
    public virtual ICollection<ProductVersionOperationSystemRelation> ProductVersionRelations { get; set; }

    /// <summary>
    /// Параметры ОС по умолчанию.
    /// </summary>
    public virtual ICollection<OperationSystemDefaultParameterValueRelation> DefaultParameterValueRelations { get; set; }
}