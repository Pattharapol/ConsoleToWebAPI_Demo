using ConsoleToWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ConsoleToWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //public EmployeeModel GetEmployees()
        //{
        //    return new EmployeeModel() { Id = 1, Name = "Employee1" };
        //}

        [Route("")]
        public List<EmployeeModel> GetEmployees()
        {
            return new List<EmployeeModel>()
            {
                new EmployeeModel(){  Id = 1, Name = "Employee1"},
                new EmployeeModel(){  Id = 2, Name = "Employee2"},
            };
        }

        [Route("{id}")]
        public IActionResult GetEmployees(int id)
        {
            // return status
            if (id == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(
                 new List<EmployeeModel>()
           {
                new EmployeeModel(){  Id = 1, Name = "Employee1"},
                new EmployeeModel(){  Id = 2, Name = "Employee2"}
           });
            }
        }

        [Route("{id}/basic")]
        public ActionResult<EmployeeModel> GetEmployeeBasicDetails(int id)
        {
            // return status
            if (id == 0)
            {
                return NotFound();
            }
            else
            {
                return new EmployeeModel() { Id = 1, Name = "Employee1" };
            }
        }
    }
}
