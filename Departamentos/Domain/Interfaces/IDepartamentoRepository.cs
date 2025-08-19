using Departamentos.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Departamentos.Domain.Interfaces
{
    public interface IDepartamentoRepository
    {
        Task<IEnumerable<Departamento>> GetAllAsync();
        Task<Departamento?> GetByIdAsync(int id);
        Task AddAsync(Departamento departamento);
        Task UpdateAsync(Departamento departamento);
        Task DeleteAsync(int id);
    }
}