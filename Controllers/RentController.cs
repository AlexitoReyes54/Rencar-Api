using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using rentCar.Models;
using rentCar.Services;

namespace rentCar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RentController : ControllerBase
    {
        RentService rentService = new RentService();
        public RentController()
        {
              
        }

    
    // GET all action
    [HttpGet]
    public IQueryable<Rent>  GetAll() =>
    rentService.GetAll();

    
    // GET by Id action
    [HttpGet("{id}")]
    public ActionResult<Rent> Get(int id)
    {
        var rent = rentService.Get(id);

        if(rent == null)
            return NotFound();

        return rent;
    }

    
    // POST action
    [HttpPost]
    public IActionResult Create(Rent Rent)
    {            
        rentService.Add(Rent);
        return CreatedAtAction(nameof(Create), new { id = Rent.Id }, Rent);
    }

    
    // PUT action
    [HttpPut("{id}")]
    public IActionResult Update(int id, Rent Rent)
    {
        if (id != Rent.Id)
            return BadRequest();

        var existingRent = rentService.Get(id);
        if(existingRent is null)
            return NotFound();

        
        rentService.Update(Rent);           

        return NoContent();
    }
    
    // DELETE action
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var rent = rentService.Get(id);

        if (rent is null)
            return NotFound();

        rentService.Delete(id);

        return NoContent();
    }

    }
}