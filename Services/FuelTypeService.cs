using rentCar.Models;
using System.Linq;

namespace  rentCar.Services
{
    public  class FuelTypeService
    {
         CarStuffContext db = new CarStuffContext();

        public FuelTypeService()
        {
            
        }

        public  IQueryable<FuelType> GetAll()
        {
            return db.Set<FuelType>();
        }

        public  FuelType Get(int id) 
        { 
            return  db.fuelTypes.Find(id);
        }

        public  void Add(FuelType FuelType)
        {
            db.Add(FuelType);
            db.SaveChanges();
        }

        public  void Delete(int id)
        {
            db.Remove(Get(id));
            db.SaveChanges();
        }

        public  void Update(FuelType FuelType)
        {
           db.Update(FuelType);
        }
    }
}