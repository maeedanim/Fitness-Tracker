using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL.DTOs
{
    public class WorkoutDTO
    {
        //copied from the model of workout model
        
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; } // Brief description of the workout
        [Required]
        public int Duration { get; set; } // Duration in minutes
        [Required]
        public int CaloriesBurned { get; set; } // Estimated calories burned
        [Required]
        public string DifficultyLevel { get; set; } // e.g., Beginner, Intermediate, Advanced
          



    }
}
