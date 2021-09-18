using rentCar.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace  rentCar.Services
{
    public  class EmployeeService
    {
         CarStuffContext db = new CarStuffContext();

        public EmployeeService()
        {
            
        }

        public  IQueryable<Employee> GetAll()
        {
            return db.Set<Employee>();
        }

        public  Employee Get(int id) 
        { 
            return  db.employees.Find(id);
        }

        public  void Add(Employee Employee)
        {
            db.Add(Employee);
            db.SaveChanges();
        }

        public  void Delete(int id)
        {
            db.Remove(Get(id));
            db.SaveChanges();
        }

        public  void Update(Employee Employee)
        {
           db.Entry(Employee).State = EntityState.Deleted;
           db.Update<Employee>(Employee);
           db.SaveChanges();
        }
    }
}