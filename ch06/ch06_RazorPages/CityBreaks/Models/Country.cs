// Listing 5.19 Adding a unique identifier in the Country.cs file in the CityBreaks/Models folder

namespace CityBreaks.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
    }
}
