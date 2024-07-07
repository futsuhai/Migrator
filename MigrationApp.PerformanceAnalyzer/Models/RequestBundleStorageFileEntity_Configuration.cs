using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#pragma warning disable SA1649
namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class RequestBundleStorageFileEntity_Configuration : IEntityTypeConfiguration<RequestBundleStorageFileEntity>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<RequestBundleStorageFileEntity> modelBuilder)
    {
        modelBuilder.HasAlternateKey(c => new { c.RequestBundleId, c.StorageFileId });
    }
}