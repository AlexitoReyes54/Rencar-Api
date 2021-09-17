using rentCar.Models;
using System.Collections.Generic;
using System.Linq;

namespace ContosoMark.Services
{
    public static class MarkService
    {
        static List<Mark> Marks { get; }
        static int nextId = 3;
        static MarkService()
        {
            Marks = new List<Mark>
            {
                new Mark { Id = 1, Description = "Red car", able = false },
                new Mark { Id = 2, Description = "Blue car", able = true }
            };
        }

        public static List<Mark> GetAll() => Marks;

        public static Mark Get(int id) => Marks.FirstOrDefault(p => p.Id == id);

        public static void Add(Mark Mark)
        {
            Mark.Id = nextId++;
            Marks.Add(Mark);
        }

        public static void Delete(int id)
        {
            var Mark = Get(id);
            if(Mark is null)
                return;

            Marks.Remove(Mark);
        }

        public static void Update(Mark Mark)
        {
            var index = Marks.FindIndex(p => p.Id == Mark.Id);
            if(index == -1)
                return;

            Marks[index] = Mark;
        }
    }
}