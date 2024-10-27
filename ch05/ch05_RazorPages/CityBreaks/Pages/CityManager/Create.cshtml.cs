// Listing 5.5 Adding a parameter in Create.cshtml.cs CityBreaks/Pages/CityManager folder

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;

namespace CityBreaks.Pages.CityManager
{
    public class CreateModel : PageModel
    {
        public string Message { get; set; }

        public void OnPost(string cityName)
        {
            Message = $"You submitted {cityName}";
        }
    }
}
