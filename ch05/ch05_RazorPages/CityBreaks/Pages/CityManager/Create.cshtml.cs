// Listing 5.2 Processing the form values in Create.cshtml.cs CityBreaks/Pages/CityManager folder

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;

namespace CityBreaks.Pages.CityManager
{
    public class CreateModel : PageModel
    {
        public string Message { get; set; }

        public void OnPost()
        {
            if (!StringValues.IsNullOrEmpty(Request.Form["cityName"]))
            {
                Message = $"You submitted {Request.Form["cityName"]}";
            }
        }
    }
}
