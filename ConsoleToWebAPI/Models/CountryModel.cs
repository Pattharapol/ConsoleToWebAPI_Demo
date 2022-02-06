using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebAPI.Models
{
    public class CountryModel
    {
        [ModelBinder(typeof(CustomBinderCountryDetails))]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Population { get; set; }

        public int Area { get; set; }
    }
}