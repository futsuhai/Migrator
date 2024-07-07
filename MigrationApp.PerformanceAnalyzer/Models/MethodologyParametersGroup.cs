using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Группы параметров в методике.
/// </summary>
[Table("MethodologyParametersGroups")]
public class MethodologyParametersGroup : EntityBase
{
    /// <summary>
    /// Методика тестирования.
    /// </summary>
    [JsonIgnore]
    public virtual MethodologyEntity Methodology { get; set; }

    /// <summary>
    /// Идентификатор методики.
    /// </summary>
    [ForeignKey("Methodology")]
    public Guid MethodologyId { get; set; }

    /// <summary>
    /// Имя.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Порядок в списке.
    /// </summary>
    public int OrderIndex { get; set; }

    /// <summary>
    /// Параметры группы.
    /// </summary>
    public virtual ICollection<MethodologyParameterRelation> Parameters { get; set; }
}