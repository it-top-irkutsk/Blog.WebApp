namespace Blog.WebApp.Models;

public record Article
{
    public int Id { get; set; }
    public string Header { get; set; }
    public string Body { get; set; }
    public string Footer { get; set; }
}