using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using rentCar.Models;
using rentCar.Services;

namespace rentCar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuelTypeController : ControllerBase
    {
        FuelTypeService fuelService = new FuelTypeService();
        public FuelTypeController()
        {
              
        }

    
    // GET all action
    [HttpGet]
    public IQueryable<FuelType>  GetAll() =>
    fuelService.GetAll();

        // GET by Id action

        // POST action

        // PUT action

        // DELETE action
    }
}