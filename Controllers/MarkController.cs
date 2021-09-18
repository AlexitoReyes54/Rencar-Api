using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using rentCar.Models;
using rentCar.Services;

namespace rentCar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MarkController : ControllerBase
    {
        MarkService markService = new MarkService();
        public MarkController()
        {
              
        }

    
    // GET all action
    [HttpGet]
    public IQueryable<Mark>  GetAll() =>
    markService.GetAll();

        // GET by Id action

        // POST action

        // PUT action

        // DELETE action
    }
}