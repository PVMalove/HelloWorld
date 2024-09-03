namespace Domain;

public class Blog
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public BlogSettings Settings { get; set; }
    public ICollection<Post>? Posts { get; set; }
}