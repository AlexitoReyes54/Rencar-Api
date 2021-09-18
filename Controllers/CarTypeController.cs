using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using rentCar.Models;
using rentCar.Services;

namespace rentCar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarTypeController : ControllerBase
    {
        CarTypeService carTypeService = new CarTypeService();
        public CarTypeController()
        {
              
        }

    
    // GET all action
    [HttpGet]
    public IQueryable<CarType>  GetAll() =>
    carTypeService.GetAll();

        // GET by Id action

        // POST action

        // PUT action

        // DELETE action
    }
}