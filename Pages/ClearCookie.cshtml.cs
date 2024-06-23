using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CookieReaderApp.Pages
{
    public class ClearCookieModel : PageModel
    {
        public IActionResult OnPost()
        {
            // Clear the cookie by setting its expiration date to a past date
            Response.Cookies.Delete("myCookie");

            // Respond with plain text
            return Content("Cookie has been cleared.", "text/plain");
        }
    }
}
