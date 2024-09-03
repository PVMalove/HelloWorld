using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence.Configurations;

namespace Persistence;

public class BlogDbContext(DbContextOptions<BlogDbContext> options) : DbContext (options)
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<BlogSettings> BlogSettings { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Tag> Tags { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new BlogConfiguration());
        builder.ApplyConfiguration(new BlogSettingsConfiguration());
        builder.ApplyConfiguration(new PostConfiguration());
        builder.ApplyConfiguration(new TagConfiguration());
        base.OnModelCreating(builder);
    }
}