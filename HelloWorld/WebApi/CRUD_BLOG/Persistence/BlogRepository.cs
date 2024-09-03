using Domain;

namespace Persistence;

public class BlogRepository (BlogDbContext context) : IBlogRepository
{
    public async Task CreateOnly(Blog blog, CancellationToken cancellationToken = default)
    {
        await context.Blogs.AddAsync(blog, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }
    
    public async Task CreateWithPosts(Blog blog, ICollection<Post> posts, CancellationToken cancellationToken = default)
    {
        await context.Blogs.AddAsync(blog, cancellationToken);

        foreach (var post in posts)
        {
            blog.Posts?.Add(post);
        }

        await context.SaveChangesAsync(cancellationToken);
    }
}