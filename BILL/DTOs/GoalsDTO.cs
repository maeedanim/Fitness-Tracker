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

        public string GoalType { get; set; } 

        [Required]
        [StringLength(350)]
        public string Description { get; set; } 


        public DateTime Startdate { get; set; } 


        public DateTime Enddate { get; set; } 

        [Required]
        public string Status { get; set; } 

    }
}
