// Listing 15.14 The CityModel class in the City.cshtml.cs file in the CityBreaks/Pages folder

using CityBreaks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityBreaks.Pages
{
	public class CityModel : PageModel
    {
        [BindProperty]
        public List<int> SelectedCities { get; set; } = new List<int>();
        public List<City> Cities = new List<City>
        {
            new City { Id = 1, Name = "London" },
            new City { Id = 2, Name = "Paris" },
            new City { Id = 3, Name = "New York" },
            new City { Id = 4, Name = "Rome" },
            new City { Id = 5, Name = "Dublin" }
        };

        public string CityName { get; set; }
        public int? Rating { get; set; }

        public void OnGet(string cityName, int rating)
        {
            CityName = cityName;
            Rating = rating;
        }
    }
}
