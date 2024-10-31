// Listing 6.2 The CreateModel for the PropertyManager in the Create.cshtml.cs file in the Pages/PropertyManager folder

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace CityBreaks.Pages.PropertyManager
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        [Display(Name="Max Number of Guests")]
        public int MaxNumberOfGuests { get; set; }
        [BindProperty]
        [Display(Name="Day Rate")]
        public decimal DayRate { get; set; }
        [BindProperty]
        [Display(Name="Smoking Permitted")]
        public bool SmokingPermitted { get; set; }
        [BindProperty]
        [Display(Name="Available From")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-ddTHH:mm}")]
        public DateTime AvailableFrom { get; set; }

        public void OnGet()
        {
        }
    }
}