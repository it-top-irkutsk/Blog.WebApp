namespace Blog.WebApp.Models;

public record ArticlesModel
{
    public IEnumerable<Article> Articles { get; init; }
}