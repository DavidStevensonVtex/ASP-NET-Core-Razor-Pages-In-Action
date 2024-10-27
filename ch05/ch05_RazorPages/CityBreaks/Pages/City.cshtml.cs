// Listing 4.4 Multiple parameters in separate URL segments in the City.cshtml.cs file in the CityBreaks/Pages folder

using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityBreaks.Pages
{
	public class CityModel : PageModel
    {
        public string CityName { get; set; }
        public int? Rating { get; set; }

        public void OnGet(string cityName, int rating)
        {
            CityName = cityName;
            Rating = rating;
        }
    }
}
