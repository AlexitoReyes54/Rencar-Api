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
    [HttpGet("{id}")]
    public ActionResult<Mark> Get(int id)
    {
        var mark = markService.Get(id);

        if(mark == null)
            return NotFound();

        return mark;
    }

    
    // POST action
    [HttpPost]
    public IActionResult Create(Mark mark)
    {            
        markService.Add(mark);
        return CreatedAtAction(nameof(Create), new { id = mark.Id }, mark);
    }

    
    // PUT action
    [HttpPut("{id}")]
    public IActionResult Update(int id, Mark mark)
    {
        if (id != mark.Id)
            return BadRequest();

        var existingMark = markService.Get(id);
        if(existingMark is null)
            return NotFound();

        
        markService.Update(mark);           

        return NoContent();
    }
    
    // DELETE action
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var mark = markService.Get(id);

        if (mark is null)
            return NotFound();

        markService.Delete(id);

        return NoContent();
    }

    }
}