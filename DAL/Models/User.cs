using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
   
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        
        public string Uname { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required, StringLength(50), EmailAddress]
        public string Email { get; set; }

        [Required, StringLength(20)]
        public string Password { get; set; }

 
        public string Role { get; set; } 

        [Required]
        public DateTime CreatedAt { get; set; }



        public virtual ICollection<Userworkout> Userworkouts { get; set; }

        public virtual ICollection<Goal> Goals { get; set; }

        public virtual ICollection<Workout> Workouts { get; set; }

        public User()
        {
            Userworkouts = new List<Userworkout>();
            Goals = new List<Goal>();
            Workouts = new List<Workout>();

        }


    }
}
