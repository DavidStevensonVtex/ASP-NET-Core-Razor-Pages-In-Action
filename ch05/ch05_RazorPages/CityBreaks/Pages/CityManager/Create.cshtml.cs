// Listing 5.3 Submitting form with HTTP Get in Create.cshtml.cs CityBreaks/Pages/CityManager folder

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;

namespace CityBreaks.Pages.CityManager
{
    public class CreateModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            if (!StringValues.IsNullOrEmpty(Request.Query["cityName"]))
            {
                Message = $"You submitted {Request.Query["cityName"]}";
            }
        }
    }
}
