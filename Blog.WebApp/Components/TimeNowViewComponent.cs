using Microsoft.AspNetCore.Mvc;

namespace Blog.WebApp.Components;

public class TimeNowViewComponent : ViewComponent
{
    public string Invoke() => DateTime.Now.ToString("g");
}