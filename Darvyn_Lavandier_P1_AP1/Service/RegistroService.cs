using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using DarvynLuisLavandier_P1_AP1.DAL;
using DarvynLuisLavandier_P1_AP1.Models;

namespace DarvynLuisLavandier_P1_AP1.Service
{
    public class RegistroService
    {
        private readonly Contexto _context;
        public RegistroService(Contexto contexto) => _context = contexto;

        public async Task<bool> Guardar(Registros registros)
        {

        }

        public async Task<bool> Insertar(Registros registros)
        {
      
        }

        public async Task<bool> Modificar(Registros registros)
        {
      
        }

        public async Task<bool> Existe(int id)
        {
          
        }

        public async Task<bool> Existe(string? nombre, int? id = null)
        {
         
        }


        public async Task<bool> Eliminar(int id)
        {
           
        }

        public async Task<Registros?> Buscar(int id)
        {
            
        }

        public async Task<List<Registros>> Listar(Expression<Func<Registros, bool>> criterio)
        {
            
        }
    }
}

