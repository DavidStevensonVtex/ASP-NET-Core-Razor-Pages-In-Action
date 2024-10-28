// Listing 5.28 Changing the OnPost handler to use the Post-Redirect-Get (PRG) pattern in the Create.cshtml.cs CityBreaks/Pages/CityManager folder

using CityBreaks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace CityBreaks.Pages.CountryManager
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; }
        public Country Country { get; set; }

        [TempData]
        public string CountryCode { get; set; }
        public string CountryName { get; set; }

        public IActionResult OnPost(InputModel input)
        {
            if (ModelState.IsValid)
            {
                CountryCode = Input.CountryCode;
                CountryName = Input.CountryName;

                return RedirectToPage("/CountryManager/Success");
            }
            return Page();
        }

        public class InputModel
        {
            [Required]
            public string CountryName { get; set; }
            [Required, StringLength(2, MinimumLength = 2, 
                ErrorMessage = "You must privide a valid two character ISO-3166-1 code")]
            public string CountryCode { get; set; }
        }
    }
}
