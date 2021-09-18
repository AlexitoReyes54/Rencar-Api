using rentCar.Models;
using System.Linq;

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

        public  void Update(Mark Mark)
        {
           db.Update(Mark);
        }
    }
}