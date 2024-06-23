using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace term_fetch_cookie.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public string CookieValue { get; set; }

    public void OnGet()
    {
        // Read the cookie value
        if (Request.Cookies.ContainsKey("myCookie"))
        {
            CookieValue = Request.Cookies["myCookie"];
        }
        else
        {
            CookieValue = "Cookie not found.";
        }
    }
}
