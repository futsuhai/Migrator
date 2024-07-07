using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class RequestReportFileEntity_Configuration : IEntityTypeConfiguration<RequestReportFileEntity>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<RequestReportFileEntity> modelBuilder)
    {
        modelBuilder.HasAlternateKey(c => new { c.RequestId, c.StorageFileId });

        modelBuilder.HasIndex(rrf => rrf.StorageFileId);
    }
}