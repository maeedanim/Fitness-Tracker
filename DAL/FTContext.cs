using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class FTContext : DbContext
    {
        public DbSet<User> Users { get; set; }  
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Userworkout> Userworkouts { get; set; }

    }
}
