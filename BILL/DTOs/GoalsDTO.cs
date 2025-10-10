using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL.DTOs
{
    public class GoalsDTO
    {
       
        public int Id { get; set; }
        public int UserId { get; set; }

        public string GoalType { get; set; } // e.g., Weight Loss, Muscle Gain, Endurance

        [Required]
        [StringLength(350)]
        public string Description { get; set; } // Brief description of the goal

        [Required]
        public DateTime Startdate { get; set; } // Target date to achieve the goal

        [Required]
        public DateTime Enddate { get; set; } // Date when the goal was created

        public string Status { get; set; } // e.g., Not Started, In Progress, Completed

    }
}
