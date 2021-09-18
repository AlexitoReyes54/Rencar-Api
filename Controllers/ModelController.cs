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
    [HttpGet("{id}")]
    public ActionResult<Model> Get(int id)
    {
        var model = modelService.Get(id);

        if(model == null)
            return NotFound();

        return model;
    }

    
    // POST action
    [HttpPost]
    public IActionResult Create(Model model)
    {            
        modelService.Add(model);
        return CreatedAtAction(nameof(Create), new { id = model.Id }, model);
    }

    
    // PUT action
    [HttpPut("{id}")]
    public IActionResult Update(int id, Model model)
    {
        if (id != model.Id)
            return BadRequest();

        var existingModel = modelService.Get(id);
        if(existingModel is null)
            return NotFound();

        
        modelService.Update(model);           

        return NoContent();
    }
    
    // DELETE action
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var model = modelService.Get(id);

        if (model is null)
            return NotFound();

        modelService.Delete(id);

        return NoContent();
    }
    
    }
}