using rentCar.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace  rentCar.Services
{
    public  class MarkService
    {
         CarStuffContext db = new CarStuffContext();

        public MarkService()
        {
            
        }

        public  IQueryable<Mark> GetAll()
        {
            return db.Set<Mark>();
        }

        public  Mark Get(int id) 
        { 
            return  db.Marks.Find(id);
        }

        public  void Add(Mark Mark)
        {
            db.Add(Mark);
            db.SaveChanges();
        }

        public  void Delete(int id)
        {
            db.Remove(Get(id));
            db.SaveChanges();
        }

        public  void Update(Mark mark)
        {
           db.Entry(mark).State = EntityState.Deleted;
           db.Update<Mark>(mark);
           db.SaveChanges();
        }
    }
}