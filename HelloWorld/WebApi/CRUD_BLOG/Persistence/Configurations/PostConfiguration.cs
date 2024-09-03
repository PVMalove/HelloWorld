using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence;

public class PostConfiguration : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.HasKey(post => post.Id);
        builder.HasIndex(post => post.Id).IsUnique();
        builder.HasMany(post => post.Tags)
            .WithMany(tag => tag.Posts);
    }
}