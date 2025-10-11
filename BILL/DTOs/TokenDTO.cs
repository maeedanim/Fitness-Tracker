using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL.DTOs
{
    public class TokenDTO
    {
     
     
        public string Tkey { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        public DateTime? Expiry { get; set; }
        public string Uname { get; set; }



    }
}
