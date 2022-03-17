using Blog.WebApp.Models;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace Blog.WebApp.Components;

public class CardViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(ArticleModel article)
    {
        return new HtmlContentViewComponentResult(
            new HtmlString( @$"
            <div class='card w-25 ms-auto'>
                <div class='card-header'>
                    <h4>{article.Header}</h4>
                </div>
                <div class='card-body'>
                    <p class='card-text'>{article.Body}</p>
                    <a href='/article/{article.Id}' class='btn btn-primary'>Подробнее ...</a>
                </div>
                <div class='card-footer text-muted'>
                    <p>{article.Footer}</p>
                </div>
            </div>" )
            );
    }
}