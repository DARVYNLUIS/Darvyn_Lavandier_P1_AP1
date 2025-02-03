using Microsoft.EntityFrameworkCore;
using DarvynLuisLavandier_AP1_P1.Models;


namespace RegistroTecnico.DAL
{
   
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Registros> Tecnicos { get; set; }



    }

}
