using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Darvyn_Lavandier_P1_AP1.DAL;
using Darvyn_Lavandier_P1_AP1.Models;

namespace Darvyn_Lavandier_P1_AP1.Service
{
    public class RegistroService
    {
        private readonly Contexto _context;
        public RegistroService(Contexto contexto) => _context = contexto;

        public async Task<bool> Guardar(Registros registros)
        {
            if (!await Existe(registros.Id))
                return await Insertar(registros);
            else
                return await Modificar(registros);
        }

        public async Task<bool> Insertar(Registros registros)
        {
            _context.Registros.Add(registros);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Modificar(Registros registros)
        {
            var local = _context.Registros.Local
             .FirstOrDefault(i => i.Id == registros.Id);
            _context.Entry(registros).State = EntityState.Modified;
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Existe(int id)
        {
            return await _context.Registros
                .AnyAsync(p => p.Id == id);
        }

        public async Task<bool> Existe(string? nombre, int? id = null)
        {
            return await _context.Registros
                .AnyAsync(p => p.Persona == nombre);
        }

        public async Task<bool> Existe(int id, string? nombre)
        {
            return await _context.Registros
                .AnyAsync(p => p.Id != id && p.Persona == nombre);
        }


        public async Task<bool> Eliminar(int id)
        {
            var registros = await _context.Registros
                .Where(p => p.Id == id)
                .ExecuteDeleteAsync();
            return registros > 0;
        }

        public async Task<Registros?> Buscar(int id)
        {
            return await _context.Registros
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Id == id);
        }
        public async Task<bool> ExistePersona(string nombre)
        {
            return await _context.Registros.AnyAsync(r => r.Persona == nombre);
        }

        public async Task<List<Registros>> Listar(Expression<Func<Registros, bool>> criterio)
        {
            return await _context.Registros
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }
    }
}