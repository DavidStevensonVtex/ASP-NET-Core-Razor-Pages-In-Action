// Listing 5.6 Binding to a public property in Create.cshtml.cs CityBreaks/Pages/CityManager folder

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;

namespace CityBreaks.Pages.CityManager
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public string CityName { get; set; }
        public string Message { get; set; }

        public void OnPost()
        {
            Message = $"You submitted {CityName}";
        }
    }
}
