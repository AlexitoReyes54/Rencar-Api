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
    [HttpGet("{id}")]
    public ActionResult<FuelType> Get(int id)
    {
        var fuelType = fuelService.Get(id);

        if(fuelType == null)
            return NotFound();

        return fuelType;
    }

    
    // POST action
    [HttpPost]
    public IActionResult Create(FuelType fuelType)
    {            
        fuelService.Add(fuelType);
        return CreatedAtAction(nameof(Create), new { id = fuelType.Id }, fuelType);
    }

    
    // PUT action
    [HttpPut("{id}")]
    public IActionResult Update(int id, FuelType fuelType)
    {
        if (id != fuelType.Id)
            return BadRequest();

        var existingFuelType = fuelService.Get(id);
        if(existingFuelType is null)
            return NotFound();

        
        fuelService.Update(fuelType);           

        return NoContent();
    }
    
    // DELETE action
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var fuelType = fuelService.Get(id);

        if (fuelType is null)
            return NotFound();

        fuelService.Delete(id);

        return NoContent();
    }
    
    }
}