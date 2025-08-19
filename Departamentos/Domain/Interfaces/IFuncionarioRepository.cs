using Departamentos.Domain.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Departamentos.Domain.Interfaces
{
    public interface IFuncionarioRepository
    {
        Task<IEnumerable<Funcionario>> GetByDepartamentoAsync(int departamentoId);
        Task<Funcionario?> GetByIdAsync(int id);
        Task AddAsync(Funcionario funcionario);
        Task UpdateAsync(Funcionario funcionario);
        Task DeleteAsync(int id);
    }
}