using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL.DTOs
{
    public class UserwithUserWorkout : UserDTO
    {
        
        public List<UserWorkoutDTO> UserWorkouts { get; set; }
        public List<GoalsDTO> Goals { get; set; }
        public UserwithUserWorkout()
        {
            UserWorkouts = new List<UserWorkoutDTO>();
            Goals = new List<GoalsDTO>();
            
        }

    }
}
