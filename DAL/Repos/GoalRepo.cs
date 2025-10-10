using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class GoalRepo : Repo, IRepo<Goal, int, bool>
    {
        public bool Create(Goal obj)
        {
            db.Goals.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var goal = Read(id);
            if (goal != null)
            {
                db.Goals.Remove(goal);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public List<Goal> Read()
        {
            return db.Goals.ToList();
        }

        public Goal Read(int id)
        {
            return db.Goals.Find(id);
        }

        public bool Update(Goal obj)
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
