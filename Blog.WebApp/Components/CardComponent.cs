using System.Text;
using Blog.WebApp.Models;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Blog.WebApp;

public static class CardComponent
{
    public static HtmlString CreateCard(this IHtmlHelper html, ArticleModel article)
    {
        return new HtmlString( @$"
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
            </div>" );
    }
}