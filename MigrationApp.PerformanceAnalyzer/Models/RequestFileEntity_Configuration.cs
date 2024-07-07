using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#pragma warning disable SA1649
namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class RequestFileEntity_Configuration : IEntityTypeConfiguration<RequestFileEntity>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<RequestFileEntity> modelBuilder)
    {
        modelBuilder.HasAlternateKey(c => new { c.RequestId, c.StorageFileId });
    }
}