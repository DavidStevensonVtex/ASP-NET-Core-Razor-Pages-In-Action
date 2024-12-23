// Listing 6.2 The CreateModel for the PropertyManager in the Create.cshtml.cs file in the Pages/PropertyManager folder

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityBreaks.Pages.PropertyManager
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public int MaxNumberOfGuests { get; set; }
        [BindProperty]
        public decimal DayRate { get; set; }
        [BindProperty]
        public bool SmokingPermitted { get; set; }
        [BindProperty]
        public DateTime AvailableFrom { get; set; }

        public void OnGet()
        {
        }
    }
}