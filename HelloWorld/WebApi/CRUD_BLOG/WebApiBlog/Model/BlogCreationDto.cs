using System.Text.Json.Serialization;
using Domain;

namespace WebApi.Model;

public class BlogCreationDto
{
    [JsonPropertyName("blog")]
    public Blog Blog { get; set; }

    [JsonPropertyName("posts")]
    public ICollection<Post> Posts { get; set; }
}