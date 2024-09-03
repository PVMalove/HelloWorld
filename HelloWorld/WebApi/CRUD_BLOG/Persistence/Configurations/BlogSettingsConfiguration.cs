using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence;

public class BlogSettingsConfiguration : IEntityTypeConfiguration<BlogSettings>
{
    public void Configure(EntityTypeBuilder<BlogSettings> builder)
    {
        builder.HasKey(blogSettings => blogSettings.Id);
        builder.HasIndex(blogSettings => blogSettings.Id).IsUnique();
    }
}