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
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Userworkout> Read()
        {
            throw new NotImplementedException();
        }

        public Userworkout Read(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Userworkout obj)
        {
            throw new NotImplementedException();
        }
    }
}
