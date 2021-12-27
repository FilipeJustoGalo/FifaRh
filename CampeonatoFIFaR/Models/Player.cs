using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CampeonatoFIFaR.Models
{
    public class Player
    {
        public int Id { get; set; }
        [Required]
        [StringLength(15)]
        public string Nome { get; set; }
        
    }
}
