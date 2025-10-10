using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<User, string, User> UserData()
        {
            return new UserRepo();
        }
        public static IRepo<Workout, int, bool> WorkoutData()
        {
            return new WorkoutRepo();
        }
        public static IRepo<Userworkout, int, bool> UserworkoutData()
        {
            return new UserworkoutRepo();
        }

        public static IRepo<Goal, int, bool> GoalData()
        {
            return new GoalRepo ();
        }

    }
}
