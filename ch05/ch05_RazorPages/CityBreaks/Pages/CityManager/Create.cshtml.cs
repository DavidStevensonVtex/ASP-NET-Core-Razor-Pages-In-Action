// Listing 5.1b The Create page with a form in Create.cshtml.cs CityBreaks/Pages/CityManager folder

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityBreaks.Pages.CityManager
{
    public class CreateModel : PageModel
    {
        public string Message { get; set; }

        public void OnPost()
        {
            Message = $"You submitted {Request.Form["cityName"]}";
        }
    }
}
