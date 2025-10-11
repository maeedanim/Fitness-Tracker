using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL.DTOs
{
    public class UserDTO
    {
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

       
        public DateTime CreatedAt { get; set; }

    }
}
