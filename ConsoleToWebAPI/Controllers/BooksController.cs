using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        // route constrain can include int bool datetime double float, 
        // min(number), max(number)
        // minlength(10), maxlength(500)
        // length(15) => exactly match at 15 chars
        // range(10,15) => between 10-15
        // alpha => all values must be only character not number
        // regex can be use too
        [Route("{id:int:min(10):max(100)}")]
        public string GetByID(int id)
        {
            return $"Hello Int {id}";
        }

        [Route("{id:length(5):alpha}")]
        public string GetByID(string id)
        {
            return $"Hello String {id}";
        }

        [Route("{id:regex(a(b|c))}")]
        public string GetByIDRegex(string id)
        {
            return $"Hello String {id}";
        }
    }
}