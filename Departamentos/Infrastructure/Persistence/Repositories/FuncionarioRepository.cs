using Departamentos.Domain.Entities;
using Departamentos.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Departamentos.Infrastructure.Persistence.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly AppDbContext _context;
        public FuncionarioRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Funcionario>> GetByDepartamentoAsync(int departamentoId)
            => await _context.Funcionarios.Where(f => f.DepartamentoId == departamentoId).ToListAsync();
        public async Task<Funcionario?> GetByIdAsync(int id)
            => await _context.Funcionarios.FirstOrDefaultAsync(f => f.Id == id);
        public async Task AddAsync(Funcionario funcionario)
        {
            var departamentoExiste = await _context.Departamentos
                .AnyAsync(d => d.Id == funcionario.DepartamentoId);

            if (!departamentoExiste)
                throw new InvalidOperationException($"Departamento com Id {funcionario.DepartamentoId} não existe.");

            _context.Funcionarios.Add(funcionario);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Funcionario funcionario)
        {
            _context.Funcionarios.Update(funcionario);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Funcionarios.FindAsync(id);
            if (entity != null)
            {
                _context.Funcionarios.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}