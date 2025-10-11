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
        
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; } 

        [Required]
        public int Duration { get; set; } 

        [Required]
        public int CaloriesBurned { get; set; }

        [Required]
        public string DifficultyLevel { get; set; } 
          



    }
}
