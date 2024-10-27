// Listing 5.10 Using an Input model to encapsulate the binding target in Create.cshtml.cs CityBreaks/Pages/CityManager folder

using CityBreaks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityBreaks.Pages.CityManager
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; }
        public Country Country { get; set; }

        public void OnPost()
        {
            Country = new Country
            {
                CountryName = Input.CountryName,
                CountryCode = Input.CountryCode
            };
        }

        public class InputModel
        {
            public string CountryName { get; set; }
            public string CountryCode { get; set; }
        }
    }
}
