// Listing 3.27 Different handler methods assigning different values to the Message property in the Welcome.cshtml.cs file in the WebApplication1/Pages folder

using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class WelcomeModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "OnGet executed";
        }

        public void OnPost()
        {
            Message = "OnPost executed";
        }
    }
}
