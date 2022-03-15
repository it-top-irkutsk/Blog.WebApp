using Blog.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.WebApp.Controllers;

public class ArticlesController : Controller
{
    private readonly ArticlesModel _articlesModel = new ArticlesModel
    {
        Articles = new List<ArticleModel>
        {
            new()
            {
                Id = 1,
                Header = "Article 1",
                Body =
                    "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Accusantium aut consequuntur, cum deleniti deserunt eaque expedita facilis, harum minima minus numquam officia officiis pariatur quam quia quisquam sit velit vero!",
                Footer = "footer"
            },
            new()
            {
                Id = 2,
                Header = "Article 2",
                Body =
                    "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Accusantium aut consequuntur, cum deleniti deserunt eaque expedita facilis, harum minima minus numquam officia officiis pariatur quam quia quisquam sit velit vero!",
                Footer = "footer"
            },
            new()
            {
                Id = 3,
                Header = "Article 3",
                Body =
                    "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Accusantium aut consequuntur, cum deleniti deserunt eaque expedita facilis, harum minima minus numquam officia officiis pariatur quam quia quisquam sit velit vero!",
                Footer = "footer"
            },
            new()
            {
                Id = 4,
                Header = "Article 4",
                Body =
                    "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Accusantium aut consequuntur, cum deleniti deserunt eaque expedita facilis, harum minima minus numquam officia officiis pariatur quam quia quisquam sit velit vero!",
                Footer = "footer"
            },
            new()
            {
                Id = 5,
                Header = "Article 5",
                Body =
                    "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Accusantium aut consequuntur, cum deleniti deserunt eaque expedita facilis, harum minima minus numquam officia officiis pariatur quam quia quisquam sit velit vero!",
                Footer = "footer"
            },
            new()
            {
                Id = 6,
                Header = "Article 6",
                Body =
                    "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Accusantium aut consequuntur, cum deleniti deserunt eaque expedita facilis, harum minima minus numquam officia officiis pariatur quam quia quisquam sit velit vero!",
                Footer = "footer"
            }
        }
    };

    [Route("articles")]
    public IActionResult Articles()
    {
        return View("ArticlesView", _articlesModel);
    }

    [Route("article/{id:int}")]
    public IActionResult Article(int id)
    {
        var article = (_articlesModel.Articles as List<ArticleModel>)?.Find(a => a.Id == id);
        return View("ArticleView", article);
    }
}