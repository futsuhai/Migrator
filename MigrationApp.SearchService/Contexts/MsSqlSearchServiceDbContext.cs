using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MigrationApp.SearchService.Models;

namespace MigrationApp.SearchService.Contexts;

/// <summary>
/// MS SQL контекст SearchService.
/// </summary>
public class MsSqlSearchServiceDbContext : DbContext
{
    public MsSqlSearchServiceDbContext(DbContextOptions<MsSqlSearchServiceDbContext> options)
        : base(options) { }
    
    /// <summary>
    /// Методики.
    /// </summary>
    public DbSet<MethodologyEntity> Methodologies { get; set; }

    /// <summary>
    /// Связи методик с локациями.
    /// </summary>
    public DbSet<MethodologyLocationRelation> MethodologyLocationRelations { get; set; }

    /// <summary>
    /// Связи методик с продуктами.
    /// </summary>
    public DbSet<MethodologyProductRelation> MethodologyProductRelations { get; set; }

    /// <summary>
    /// Продукты.
    /// </summary>
    public DbSet<ProductEntity> Products { get; set; }
    
    /// <inheritdoc />
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

        foreach (var entity in modelBuilder.Model.GetEntityTypes())
        {
            foreach (var property in entity.GetProperties().Where(p => p.IsPrimaryKey()))
            {
                property.ValueGenerated = ValueGenerated.Never;
            }
        }
    }
}