using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CampeonatoFIFaR.Models
{
    public class Torneio
    {
        public int id { get; set; }
        [Required]
        [StringLength(15)]
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int QuantClube { get; set; }
        public Clube Clube { get; set; }
        public int ClubeId { get; set; }

    }
}
