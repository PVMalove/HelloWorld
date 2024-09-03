using Domain;

namespace Persistence;

public interface IBlogRepository
{
    Task CreateOnly(Blog blog, CancellationToken cancellationToken = default);
    Task CreateWithPosts (Blog blog, ICollection<Post> posts, CancellationToken cancellationToken = default);
}