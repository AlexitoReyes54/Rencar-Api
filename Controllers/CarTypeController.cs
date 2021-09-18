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
    [HttpGet("{id}")]
    public ActionResult<CarType> Get(int id)
    {
        var carType = carTypeService.Get(id);

        if(carType == null)
            return NotFound();

        return carType;
    }

    
    // POST action
    [HttpPost]
    public IActionResult Create(CarType carType)
    {            
        carTypeService.Add(carType);
        return CreatedAtAction(nameof(Create), new { id = carType.Id }, carType);
    }

    
    // PUT action
    [HttpPut("{id}")]
    public IActionResult Update(int id, CarType carType)
    {
        if (id != carType.Id)
            return BadRequest();

        var existingCarType = carTypeService.Get(id);
        if(existingCarType is null)
            return NotFound();

        
        carTypeService.Update(carType);           

        return NoContent();
    }
    
    // DELETE action
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var carType = carTypeService.Get(id);

        if (carType is null)
            return NotFound();

        carTypeService.Delete(id);

        return NoContent();
    }
    
    }
}