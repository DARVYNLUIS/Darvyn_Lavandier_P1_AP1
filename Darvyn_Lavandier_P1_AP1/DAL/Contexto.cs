using Microsoft.EntityFrameworkCore;
using Darvyn_Lavandier_P1_AP1.Models;
namespace Darvyn_Lavandier_P1_AP1.DAL
{

    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Registros> Registros { get; set; }




    }

}
