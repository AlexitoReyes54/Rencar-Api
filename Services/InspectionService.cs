using rentCar.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace  rentCar.Services
{
    public  class InspectionService
    {
         CarStuffContext db = new CarStuffContext();

        public InspectionService()
        {
            
        }

        public  IQueryable<Inspection> GetAll()
        {
            return db.Set<Inspection>();
        }

        public  Inspection Get(int id) 
        { 
            return  db.inspections.Find(id);
        }

        public  void Add(Inspection Inspection)
        {
            db.Add(Inspection);
            db.SaveChanges();
        }

        public  void Delete(int id)
        {
            db.Remove(Get(id));
            db.SaveChanges();
        }

        public  void Update(Inspection Inspection)
        {
           db.Entry(Inspection).State = EntityState.Deleted;
           db.Update<Inspection>(Inspection);
           db.SaveChanges();
        }
    }
}