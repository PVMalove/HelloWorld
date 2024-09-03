namespace Domain;

public class BlogSettings
{
    public Guid Id { get; set; }
    public string Value { get; set; }
    public Blog Blog { get; set; }
    public Guid BlogId { get; set; }
}