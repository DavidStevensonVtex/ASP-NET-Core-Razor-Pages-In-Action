// Listing 4.14 Generating an array of cities in the PageModel in Index.cshtml.cs in the CityBreaks/Pages folder

using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityBreaks.Pages
{
    public class IndexModel : PageModel
	{
		public string[] Cities { get; set; }

		public void OnGet()
		{
			Cities = new[] { "London", "Berlin", "Paris", "Rome", "New York" }; 
        }
    }
}
