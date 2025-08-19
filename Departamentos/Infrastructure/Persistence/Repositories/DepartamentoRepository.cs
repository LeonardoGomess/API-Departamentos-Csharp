using Departamentos.Domain.Entities;
using Departamentos.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Departamentos.Infrastructure.Persistence.Repositories
{
    public class DepartamentoRepository : IDepartamentoRepository
    {
        private readonly AppDbContext _context;
        public DepartamentoRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Departamento>> GetAllAsync()
            => await _context.Departamentos.Include(d => d.Funcionarios).ToListAsync();
        public async Task<Departamento?> GetByIdAsync(int id)
            => await _context.Departamentos.Include(d => d.Funcionarios).FirstOrDefaultAsync(d => d.Id == id);
        public async Task AddAsync(Departamento departamento)
        {
            _context.Departamentos.Add(departamento);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Departamento departamento)
        {
            _context.Departamentos.Update(departamento);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Departamentos.FindAsync(id);
            if (entity != null)
            {
                _context.Departamentos.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}