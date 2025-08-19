using Departamentos.Application.Dtos;
using Departamentos.Domain.Entities;
using Departamentos.Domain.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace Departamentos.Application.UseCases.Funcionario
{
    public class GetFuncionariosByDepartamentoUseCase
    {
        private readonly IFuncionarioRepository _repository;
        public GetFuncionariosByDepartamentoUseCase(IFuncionarioRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<FuncionarioDto>> ExecuteAsync(int departamentoId)
        {
            var funcionarios = await _repository.GetByDepartamentoAsync(departamentoId);
            return funcionarios.Select(f => new FuncionarioDto
            {
                Id = f.Id,
                Nome = f.Nome,
                Foto = f.Foto,
                RG = f.RG,
                DepartamentoId = f.DepartamentoId
            });
        }
    }
}