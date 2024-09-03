using Microsoft.AspNetCore.Mvc;
using Persistence;
using WebApi.Model;

namespace WebApi.Controllers;

[ApiController]
[Route("Blog")]
public class BlogController(IBlogRepository blogRepository) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateNoteAsync([FromBody] BlogCreationDto dto, CancellationToken cancellationToken = default)
    {
        var blog = dto.Blog;
        var posts = dto.Posts;

        await blogRepository.CreateWithPosts(blog, posts, cancellationToken);
        return NoContent();
    }
}