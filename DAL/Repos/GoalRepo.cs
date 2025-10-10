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
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Goal> Read()
        {
            throw new NotImplementedException();
        }

        public Goal Read(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Goal obj)
        {
            throw new NotImplementedException();
        }
    }
}
