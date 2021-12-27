using CampeonatoFIFaR.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CampeonatoFIFaR.Data
{
    public class PlayerContext : DbContext

    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Clube> Clubes { get; set; }
        public DbSet<Torneio> Torneios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CampeonatoDb;Data Source=DESKTOP-LFQI6IA\\SQLEXPRESS");

        }
    }
}