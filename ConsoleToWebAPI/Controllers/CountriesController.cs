using ConsoleToWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        // pass values as form-data
        //[BindProperty]
        //[BindProperty(supportsGet = true)]

        //public CountryModel country { get; set; }

        //public string Name { get; set; }

        //public int Population { get; set; }

        //public int Area { get; set; }

        // pass data from url like ~/api/countries?name=XXX&area=xxx
        //[HttpPost("{name}/{area}")]
        //public IActionResult AddCountry(string name, int area)
        //{
        //    return Ok($"Name = {name}, Area = {area}");
        //    //return Ok($"Name = {this.country.Name}, Population = {this.country.Population}, Area = {this.country.Area}");
        //}

        //[HttpPost("")]
        //public IActionResult AddCountry(CountryModel country)
        //{
        //    return Ok($"Name = {country.Name}, Population = {country.Population}, Area = {country.Area}");
        //    //return Ok($"Name = {this.country.Name}, Population = {this.country.Population}, Area = {this.country.Area}");
        //}

        //[HttpPost("")]
        //public IActionResult AddCountry([FromQuery] CountryModel model)
        //{
        //    return Ok($"Name = {model.Name}");
        //    //return Ok($"Name = {country.Name}, Population = {country.Population}, Area = {country.Area}");
        //    //return Ok($"Name = {this.country.Name}, Population = {this.country.Population}, Area = {this.country.Area}");
        //}

        [HttpPost("{name}/{population}/{area}")]
        public IActionResult AddCountry([FromRoute] CountryModel model)
        {
            return Ok($"Name = {model.Name}");
            //return Ok($"Name = {country.Name}, Population = {country.Population}, Area = {country.Area}");
            //return Ok($"Name = {this.country.Name}, Population = {this.country.Population}, Area = {this.country.Area}");
        }
    }
}