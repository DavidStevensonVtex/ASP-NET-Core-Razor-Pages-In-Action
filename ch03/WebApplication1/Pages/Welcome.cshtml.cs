// Listing 3.29 Adding a parameter to the OnGet handler method in the Welcome.cshtml.cs file in the WebApplication1/Pages folder

using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class WelcomeModel : PageModel
    {
        public string Message { get; set; } = string.Empty;

        public void OnGet(int id)
        {
            Message = $"OnGet executed with id = {id}";
        }

        public void OnPost()
        {
            Message = "OnPost executed";
        }
    }
}
