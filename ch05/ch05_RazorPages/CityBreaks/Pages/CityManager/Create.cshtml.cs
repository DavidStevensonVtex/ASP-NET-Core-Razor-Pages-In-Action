// Listing 5.16 The CreateModel class in the country manager in Create.cshtml.cs CityBreaks/Pages/CityManager folder

using CityBreaks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityBreaks.Pages.CityManager
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public List<InputModel> Inputs { get; set; }
        public List<Country> Countries { get; set; } = new List<Country>();

        public void OnPost(InputModel input)
        {
            Countries = Inputs
                .Where(x => !string.IsNullOrEmpty(x.CountryCode))
                .Select(x => new Country
                {
                    CountryCode = x.CountryCode,
                    CountryName = x.CountryName
                })
                .ToList();
        }

        public class InputModel
        {
            public string CountryName { get; set; }
            public string CountryCode { get; set; }
        }
    }
}
