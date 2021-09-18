using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using rentCar.Models;
using rentCar.Services;

namespace rentCar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        CarService carService = new CarService();
        public CarController()
        {
              
        }

    
    // GET all action
    [HttpGet]
    public IQueryable<Car>  GetAll() =>
    carService.GetAll();

    
    // GET by Id action
    [HttpGet("{id}")]
    public ActionResult<Car> Get(int id)
    {
        var car = carService.Get(id);

        if(car == null)
            return NotFound();

        return car;
    }

    
    // POST action
    [HttpPost]
    public IActionResult Create(Car Car)
    {            
        carService.Add(Car);
        return CreatedAtAction(nameof(Create), new { id = Car.Id }, Car);
    }

    
    // PUT action
    [HttpPut("{id}")]
    public IActionResult Update(int id, Car Car)
    {
        if (id != Car.Id)
            return BadRequest();

        var existingCar = carService.Get(id);
        if(existingCar is null)
            return NotFound();

        
        carService.Update(Car);           

        return NoContent();
    }
    
    // DELETE action
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var car = carService.Get(id);

        if (car is null)
            return NotFound();

        carService.Delete(id);

        return NoContent();
    }

    }
}