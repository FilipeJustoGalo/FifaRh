using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampeonatoFIFaR.Models
{
    public class Clube
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Player Player { get; set; }
        public int PlayerId { get; set; }
        
    }
}
