using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MigrationApp.PerformanceAnalyzer.Models;

/// <inheritdoc />
internal class UserEntity_Configuration : IEntityTypeConfiguration<UserEntity>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder
            .HasMany(x => x.TestedRequests)
            .WithOne(x => x.Tester);

        builder.HasAlternateKey(c => new { c.AdLogin });

        builder.Property(c => c.AdLogin)
            .HasMaxLength(64)
            .IsRequired();

        NpgsqlIndexBuilderExtensions.IncludeProperties(
            builder.HasIndex(u => u.Id),
            u => new object[] { u.Group });

        NpgsqlIndexBuilderExtensions.IncludeProperties(
            builder.HasIndex(u => u.Id),
            u => new object[] { u.Name });

        builder.HasIndex(u => new
        {
            u.AdLogin,
            u.Id,
            u.IsBot,
        });

        NpgsqlIndexBuilderExtensions.IncludeProperties(
            builder.HasIndex(u => u.Id),
            u => new object[]
            {
                u.AdLogin,
                u.Name,
                u.Email,
                u.Department,
                u.JobPosition,
                u.Company,
                u.CreatedAt,
                u.ModifiedAt,
                u.CreatedBy,
                u.Language,
                u.Group,
                u.IsBot,
                u.Roles,
                u.OfficeId,
                u.MaxActiveRequests,
            });
    }
}