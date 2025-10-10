using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class UserworkoutRepo : Repo, IRepo<Userworkout, int, bool>
    {
        public bool Create(Userworkout obj)
        {
            db.Userworkouts.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var userworkout = Read(id);
            if (userworkout != null)
            {
                db.Userworkouts.Remove(userworkout);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public List<Userworkout> Read()
        {
            return db.Userworkouts.ToList();
        }

        public Userworkout Read(int id)
        {
            return db.Userworkouts.Find(id);
        }

        public bool Update(Userworkout obj)
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
