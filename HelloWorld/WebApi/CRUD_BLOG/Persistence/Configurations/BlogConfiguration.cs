using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

public class BlogConfiguration : IEntityTypeConfiguration<Blog>
{
    public void Configure(EntityTypeBuilder<Blog> builder)
    {
        builder.HasKey(blog => blog.Id);
        builder.HasIndex(blog => blog.Id).IsUnique();
        builder.HasOne(blog => blog.Settings)
            .WithOne(settings => settings.Blog)
            .HasForeignKey<BlogSettings>(blog => blog.BlogId);

        builder.HasMany(blog => blog.Posts)
            .WithOne(post => post.Blog)
            .HasForeignKey(post => post.BlogId);
    }
}