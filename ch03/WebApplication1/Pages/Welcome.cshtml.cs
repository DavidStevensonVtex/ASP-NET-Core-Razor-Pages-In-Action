// Listing 3.34 Page() method shorthand for new PageResult() in the Welcome.cshtml.cs file in the WebApplication1/Pages folder

using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class WelcomeModel : PageModel
    {
        public string Message { get; set; } = string.Empty;

        public PageResult OnPostSearch(string searchTerm)
        {
            Message = $"You searched for {searchTerm}";
            return Page();
        }

        public void OnPostRegister(string email)
        {
            Message = $"You registered {email} for newsletters";
        }
    }
}
