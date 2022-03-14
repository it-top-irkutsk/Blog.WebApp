using Blog.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.WebApp.Controllers;

public class ArticlesController : Controller
{
    private ArticlesModel _articlesModel = new ArticlesModel
    { 
        Articles = new List<Article>
        {
            new ()
            {
                Id = 1,
                Header = "Article",
                Body = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Accusantium aut consequuntur, cum deleniti deserunt eaque expedita facilis, harum minima minus numquam officia officiis pariatur quam quia quisquam sit velit vero!",
                Footer = "footer"
            },
            new ()
            {
                Id = 1,
                Header = "Article",
                Body = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Accusantium aut consequuntur, cum deleniti deserunt eaque expedita facilis, harum minima minus numquam officia officiis pariatur quam quia quisquam sit velit vero!",
                Footer = "footer"
            },
            new ()
            {
                Id = 1,
                Header = "Article",
                Body = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Accusantium aut consequuntur, cum deleniti deserunt eaque expedita facilis, harum minima minus numquam officia officiis pariatur quam quia quisquam sit velit vero!",
                Footer = "footer"
            },
            new ()
            {
                Id = 1,
                Header = "Article",
                Body = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Accusantium aut consequuntur, cum deleniti deserunt eaque expedita facilis, harum minima minus numquam officia officiis pariatur quam quia quisquam sit velit vero!",
                Footer = "footer"
            },
            new ()
            {
                Id = 1,
                Header = "Article",
                Body = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Accusantium aut consequuntur, cum deleniti deserunt eaque expedita facilis, harum minima minus numquam officia officiis pariatur quam quia quisquam sit velit vero!",
                Footer = "footer"
            },
            new ()
            {
                Id = 1,
                Header = "Article",
                Body = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Accusantium aut consequuntur, cum deleniti deserunt eaque expedita facilis, harum minima minus numquam officia officiis pariatur quam quia quisquam sit velit vero!",
                Footer = "footer"
            }
        }
    };

    [Route("articles")]
    public IActionResult Index()
    {
        return View("Index", _articlesModel);
    }
}