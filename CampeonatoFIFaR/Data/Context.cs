using CampeonatoFIFaR.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CampeonatoFIFaR.Data
{
    public class Context : DbContext

    {
        public Context(DbContextOptions<Context> options): base(options)
        {

        }
        public DbSet<Player> Players { get; set; }
        public DbSet<Clube> Clubes { get; set; }
        public DbSet<Torneio> Torneios { get; set; }


    }
}