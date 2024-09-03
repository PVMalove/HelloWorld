using Domain;

namespace BisinessLogic;

public interface INoteService
{
    Task CreateAsync(string text, CancellationToken cancellationToken = default);
    
    Task CreateOnly(string Name, CancellationToken cancellationToken = default);
    Task CreateWithPosts (string Name, ICollection<Post> posts, CancellationToken cancellationToken = default);

}