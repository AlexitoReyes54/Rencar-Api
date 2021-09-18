using rentCar.Models;
using System.Linq;

namespace  rentCar.Services
{
    public  class ModelService
    {
         CarStuffContext db = new CarStuffContext();

        public ModelService()
        {
            
        }

        public  IQueryable<Model> GetAll()
        {
            return db.Set<Model>();
        }

        public  Model Get(int id) 
        { 
            return  db.models.Find(id);
        }

        public  void Add(Model Model)
        {
            db.Add(Model);
            db.SaveChanges();
        }

        public  void Delete(int id)
        {
            db.Remove(Get(id));
            db.SaveChanges();
        }

        public  void Update(Model Model)
        {
           db.Update(Model);
        }
    }
}