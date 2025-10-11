using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class WorkoutRepo : Repo, IRepo<Workout, int, bool>
    {
        public bool Create(Workout obj)
        {
            db.Workouts.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var workout = Read(id);
            if (workout != null)
            {
                db.Workouts.Remove(workout);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public List<Workout> Read()
        {
            return db.Workouts.ToList();
        }

        public Workout Read(int id)
        {
            return db.Workouts.Find(id);
        }

        public bool Update(Workout obj)
        {
            var ex = Read(obj.Id);
            if (ex != null)
            {
                db.Entry(ex).CurrentValues.SetValues(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
