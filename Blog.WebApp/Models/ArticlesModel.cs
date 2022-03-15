namespace Blog.WebApp.Models;

public record ArticlesModel
{
    public IEnumerable<ArticleModel> Articles { get; init; }
}