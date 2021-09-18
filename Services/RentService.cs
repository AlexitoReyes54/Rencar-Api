using rentCar.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace  rentCar.Services
{
    public  class RentService
    {
         CarStuffContext db = new CarStuffContext();

        public RentService()
        {
            
        }

        public  IQueryable<Rent> GetAll()
        {
            return db.Set<Rent>();
        }

        public  Rent Get(int id) 
        { 
            return  db.rents.Find(id);
        }

        public  void Add(Rent Rent)
        {
            db.Add(Rent);
            db.SaveChanges();
        }

        public  void Delete(int id)
        {
            db.Remove(Get(id));
            db.SaveChanges();
        }

        public  void Update(Rent Rent)
        {
           db.Entry(Rent).State = EntityState.Deleted;
           db.Update<Rent>(Rent);
           db.SaveChanges();
        }
    }
}