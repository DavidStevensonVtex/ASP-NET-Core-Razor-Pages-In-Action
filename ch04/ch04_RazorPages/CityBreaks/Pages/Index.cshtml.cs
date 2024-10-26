// Listing 4.10 Generating an absolute URL with IUrlHelper in Index.cshtml.cs in the CityBreaks/Pages folder

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityBreaks.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;

		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{
			var target = Url.PageLink("City", values: new { cityName = "Berlin", rating = 4 });
            // target has the value "https://localhost:7245/City/Berlin/4"
        }
    }
}
