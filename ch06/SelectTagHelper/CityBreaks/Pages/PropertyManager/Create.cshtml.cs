// Listing 6.12 The PageModel properties for the multiple select list in the Create.cshtml.cs file in the Pages/PropertyManager folder

using CityBreaks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        [BindProperty]
        [Display(Name = "City")]
        public int[] SelectedCities { get; set; }
        public SelectList Cities { get; set; }
        public string Message { get; set; }


        public void OnGet()
        {
            Cities = GetCityOptions();
            SelectedCities = new int[] { 3 };
        }

        public void OnPost()
        {
            Cities = GetCityOptions();
            if (ModelState.IsValid)
            {
                var city = GetCityOptions().First(o => o.Value == SelectedCities.ToString());
                Message = $"You selected {city.Text} with value of {SelectedCities}";
            }
        }

        private SelectList GetCityOptions()
        {
            var cities = new List<SelectListItem>
            {
                new SelectListItem { Value = "1", Text = "London" },
                new SelectListItem { Value = "2", Text = "Paris" },
                new SelectListItem { Value = "3", Text = "New York" },
                new SelectListItem { Value = "4", Text = "Rome" },
                new SelectListItem { Value = "5", Text = "Dublin" }
            };

            return new SelectList(cities, nameof(SelectListItem.Value), nameof(SelectListItem.Text));
        }
    }
}