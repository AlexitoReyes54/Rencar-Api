using rentCar.Models;
using System.Linq;

namespace  rentCar.Services
{
    public  class CarTypeService
    {
         CarStuffContext db = new CarStuffContext();

        public CarTypeService()
        {
            
        }

        public  IQueryable<CarType> GetAll()
        {
            return db.Set<CarType>();
        }

        public  CarType Get(int id) 
        { 
            return  db.carTypes.Find(id);
        }

        public  void Add(CarType CarType)
        {
            db.Add(CarType);
            db.SaveChanges();
        }

        public  void Delete(int id)
        {
            db.Remove(Get(id));
            db.SaveChanges();
        }

        public  void Update(CarType CarType)
        {
           db.Update(CarType);
        }
    }
}