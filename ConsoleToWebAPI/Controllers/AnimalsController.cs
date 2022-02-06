using ConsoleToWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleToWebAPI.Controllers
{
    /// <summary>
    /// return status 200 OK with object
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private List<AnimalModel> animals = null;

        public AnimalsController()
        {
            animals = new List<AnimalModel>()
            {
               new AnimalModel(){Id = 1, Name="Tiger"},
                new AnimalModel(){Id = 2, Name="Lion"},
            };
        }

        [Route("")]
        public IActionResult GetAnimals()
        {
            return Ok(animals);
        }

        [Route("test")]
        public IActionResult GetAnimalsTest()
        {
            //// fetch data
            //var animals = new List<AnimalModel>()
            //{
            //    new AnimalModel(){Id = 1, Name="Cat"},
            //    new AnimalModel(){Id = 2, Name="Dog"},
            //};
            //return Accepted("api/animals");
            //return AcceptedAtAction("GetAnimals");
            //return AcceptedAtRoute("All");
            return LocalRedirect("~/api/animals");
        }

        [Route("{name}")]
        public IActionResult GetAnimalsByName(string name)
        {
            if (!name.Contains("ABC"))
            {
                return BadRequest();
            }
            return Ok(animals);
        }

        [Route("{id:int}")]
        public IActionResult GetAnimalsByName(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var animal = animals.FirstOrDefault(x => id == x.Id);
            if (animal == null)
            {
                return NotFound();
            }

            return Ok(animal);
        }

        [HttpPost("")]
        public IActionResult GetAnimals(AnimalModel animal)
        {
            animals.Add(animal);

            //return Created("~/api/animals/" +animal.Id, animal);
            return CreatedAtAction("GetAnimalsById", new { id = animal.Id }, animal);
        }
    }
}