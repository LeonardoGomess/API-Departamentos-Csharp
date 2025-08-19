using Departamentos.Application.Dtos;
using Departamentos.Domain.Interfaces;
using System.Threading.Tasks;

namespace Departamentos.Application.UseCases.Funcionario
{
    public class UpdateFuncionarioUseCase
    {
        private readonly IFuncionarioRepository _repository;
        public UpdateFuncionarioUseCase(IFuncionarioRepository repository)
        {
            _repository = repository;
        }
        public async Task ExecuteAsync(FuncionarioDto dto)
        {
            var funcionario = await _repository.GetByIdAsync(dto.Id);
            if (funcionario != null)
            {
                funcionario.Nome = dto.Nome;
                funcionario.Foto = dto.Foto;
                funcionario.RG = dto.RG;
                funcionario.DepartamentoId = dto.DepartamentoId;
                await _repository.UpdateAsync(funcionario);
            }
        }
    }
}