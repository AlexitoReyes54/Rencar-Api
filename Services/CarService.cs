using rentCar.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace  rentCar.Services
{
    public  class CarService
    {
         CarStuffContext db = new CarStuffContext();

        public CarService()
        {
            
        }

        public  IQueryable<Car> GetAll()
        {
            return db.Set<Car>();
        }

        public  Car Get(int id) 
        { 
            return  db.cars.Find(id);
        }

        public  void Add(Car Car)
        {
            db.Add(Car);
            db.SaveChanges();
        }

        public  void Delete(int id)
        {
            db.Remove(Get(id));
            db.SaveChanges();
        }

        public  void Update(Car car)
        {
           db.Entry(car).State = EntityState.Deleted;
           db.Update<Car>(car);
           db.SaveChanges();
        }
    }
}