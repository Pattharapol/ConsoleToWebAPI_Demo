using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [Route("{id:int:min(10):max(100)}")]
        public string GetByID(int id)
        {
            return $"Hello Int {id}";
        }

        [Route("{id}:minlength(5)")]
        public string GetByID(string id)
        {
            return $"Hello String {id}";
        }
    }
}