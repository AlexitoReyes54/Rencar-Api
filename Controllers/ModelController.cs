using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using rentCar.Models;
using rentCar.Services;

namespace rentCar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ModelController : ControllerBase
    {
        ModelService modelService = new ModelService();
        public ModelController()
        {
              
        }

    
    // GET all action
    [HttpGet]
    public IQueryable<Model>  GetAll() =>
    modelService.GetAll();

        // GET by Id action

        // POST action

        // PUT action

        // DELETE action
    }
}