using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
  
    public class Workout
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(350)]
        public string Description { get; set; } // Brief description of the workout

        [Required]
        public int Duration { get; set; } // Duration in minutes

        [Required]
        public int CaloriesBurned { get; set; } // Estimated calories burned

        public string DifficultyLevel { get; set; } // e.g., Beginner, Intermediate, Advanced
        


        
    }
}
