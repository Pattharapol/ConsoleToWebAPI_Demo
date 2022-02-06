using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ValuesController : ControllerBase
    {
        //[Route("api/get-all")]
        //[Route("getall")]
        //[Route("get-all")]
        public string GetAll()
        {
            return "Hello from GetAll();";
        }

        //[Route("api/get-all-authors")]
        public string GetAllAuthors()
        { //[Route("get-all")] => this is not possible coz we have one above GetAll();
            return "Hello from GetAllAuthors();";
        }

        // [Route("books/{id}")]
        [Route("{id}")]
        public string GetByID(int id)
        {
            // https://localhost:44363/[controller]/[action]/id
            return $"Hello Book ID => {id}";
        }

        // [Route("books/{id}/author/{authorId}")]
        public string GetAuthorAddressByID(int id, int authorId)
        {
            return $"Hello Book ID => {id} and Author ID => {authorId}";
        }

        //  [Route("search")]
        public string SearchBooks(int id, int authorId, string name, int rating, int price)
        {
            // https://localhost:44363/search?name=TIK one by one
            // https://localhost:44363/search?name=TIK&id=2&authorId=3&price=200 multiple params search
            return $"Hello from {name}";
        }
    }
}