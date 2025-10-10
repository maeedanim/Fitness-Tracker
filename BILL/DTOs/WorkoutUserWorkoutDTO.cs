using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL.DTOs
{
    public class WorkoutUserWorkoutDTO : WorkoutDTO
    {
        public List<UserWorkoutDTO> UserWorkouts { get ; set; }
        public WorkoutUserWorkoutDTO() { 
            UserWorkouts = new List<UserWorkoutDTO>();
        }

    }
}
