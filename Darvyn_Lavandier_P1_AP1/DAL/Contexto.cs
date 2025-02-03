using Microsoft.EntityFrameworkCore;
using DarvynLuisLavandier_P1_AP1.Models;
namespace DarvynLuisLavandier_P1_AP1.DAL
{
   
    public class Contexto : DbContext
    {
        public DbSet<Registros> Registros { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        

    }

}
