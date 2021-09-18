using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using rentCar.Models;
using rentCar.Services;

namespace rentCar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InspectionController : ControllerBase
    {
        InspectionService InspectionService = new InspectionService();
        public InspectionController()
        {
              
        }

    
    // GET all action
    [HttpGet]
    public IQueryable<Inspection>  GetAll() =>
    InspectionService.GetAll();

    
    // GET by Id action
    [HttpGet("{id}")]
    public ActionResult<Inspection> Get(int id)
    {
        var inspection = InspectionService.Get(id);

        if(inspection == null)
            return NotFound();

        return inspection;
    }

    
    // POST action
    [HttpPost]
    public IActionResult Create(Inspection Inspection)
    {            
        InspectionService.Add(Inspection);
        return CreatedAtAction(nameof(Create), new { id = Inspection.Id }, Inspection);
    }

    
    // PUT action
    [HttpPut("{id}")]
    public IActionResult Update(int id, Inspection Inspection)
    {
        if (id != Inspection.Id)
            return BadRequest();

        var existingInspection = InspectionService.Get(id);
        if(existingInspection is null)
            return NotFound();

        
        InspectionService.Update(Inspection);           

        return NoContent();
    }
    
    // DELETE action
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var inspection = InspectionService.Get(id);

        if (inspection is null)
            return NotFound();

        InspectionService.Delete(id);

        return NoContent();
    }

    }
}