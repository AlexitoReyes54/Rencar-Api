using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using rentCar.Models;
using rentCar.Services;

namespace rentCar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        EmployeeService employeeService = new EmployeeService();
        public EmployeeController()
        {
              
        }

    
    // GET all action
    [HttpGet]
    public IQueryable<Employee>  GetAll(){
        Response.Headers.Add("X-reponse-from-controller", "test123");
         return employeeService.GetAll();
    }
    

    
    // GET by Id action
    [HttpGet("{id}")]
    public ActionResult<Employee> Get(int id)
    {
        var employee = employeeService.Get(id);

        if(employee == null)
            return NotFound();

        return employee;
    }

    
    // POST action
    [HttpPost]
    public IActionResult Create(Employee Employee)
    {            
        employeeService.Add(Employee);
        return CreatedAtAction(nameof(Create), new { id = Employee.Id }, Employee);
    }

    
    // PUT action
    [HttpPut("{id}")]
    public IActionResult Update(int id, Employee Employee)
    {
        if (id != Employee.Id)
            return BadRequest();

        var existingEmployee = employeeService.Get(id);
        if(existingEmployee is null)
            return NotFound();

        
        employeeService.Update(Employee);           

        return NoContent();
    }
    
    // DELETE action
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var employee = employeeService.Get(id);

        if (employee is null)
            return NotFound();

        employeeService.Delete(id);

        return NoContent();
    }

    }
}