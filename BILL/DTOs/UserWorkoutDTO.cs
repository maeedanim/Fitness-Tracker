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
    public class UserWorkoutDTO
    {
   
        public int Id { get; set; }

        
        public int UserId { get; set; }

        public int WorkoutId { get; set; }

     
        public int BurnedCalories { get; set; }


        public DateTime Date { get; set; }

    }
}
