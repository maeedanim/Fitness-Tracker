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
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
