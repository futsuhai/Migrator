using System.ComponentModel.DataAnnotations.Schema;
using MigrationApp.Common.Models;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <summary>
/// Базовый класс entity.
/// </summary>
public abstract class EntityBase : IEntityBase
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    /// <summary>
    /// Дата создания.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Дата изменения.
    /// </summary>
    public DateTime ModifiedAt { get; set; }

    /// <summary>
    /// Автор изменения.
    /// </summary>
    public Guid ModifiedBy { get; set; }

    /// <summary>
    /// Автор создания.
    /// </summary>
    public Guid CreatedBy { get; set; }

    //// public override bool Equals(object obj)
    //// {
    ////    if (obj == null)
    ////    {
    ////        return false;
    ////    }
    ////
    ////    if (Id != (obj as EntityBase)?.Id)
    ////    {
    ////        return false;
    ////    }
    ////
    ////    var myType = ObjectContext.GetObjectType(GetType());
    ////    var objectType = ObjectContext.GetObjectType(obj.GetType());
    ////
    ////    return myType == objectType;
    //// }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        // Overflow is fine, just wrap
        unchecked
        {
            // Можно раскомментировать для дополнительной точности.
            // var entityType = ObjectContext.GetObjectType(GetType());
            int hash = 17;
            hash = (hash * 23) + Id.GetHashCode();

            // hash = hash * 23 + entityType.GetHashCode();
            return hash;
        }
    }

    /// <inheritdoc />
    public override string ToString()
    {
        var nameProp = GetType().GetProperties()
            .FirstOrDefault(x => x.Name == "Name");

        if (nameProp != null)
        {
            var namePropValue = nameProp.GetValue(this);
            if (namePropValue != null)
            {
                return nameProp.GetValue(this).ToString();
            }
        }

        return base.ToString();
    }
}