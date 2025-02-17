using System.Linq.Expressions;
using Darvyn_Lavandier_P1_AP1.DAL;
using Microsoft.EntityFrameworkCore;
namespace Darvyn_Lavandier_P1_AP1.Services
{
    public class Servicio(IDbContextFactory<Contexto> DbFactory)
    {
       
        public async Task<bool> Guardar()
        {
            return true;
        }
  
        public async Task<bool> Existe()
        {
            return true;
        }
  
        public async Task<bool> Insertar()
        {
            return false;
        }

        public async Task<bool> Modificar()
        {
            return true;
        }
     
        public async Task<bool> Buscar(int id)
        {

            return true;
        }

        public async Task<bool> Eliminar()
        {
            return true;
        }

        public async Task<bool> Listar()
        {
            return true;
        }
    }
}