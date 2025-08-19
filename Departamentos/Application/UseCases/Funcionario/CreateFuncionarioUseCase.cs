using Departamentos.Application.Dtos;
using Departamentos.Domain.Entities;
using Departamentos.Domain.Interfaces;
using System.Threading.Tasks;

namespace Departamentos.Application.UseCases.Funcionario
{
    public class CreateFuncionarioUseCase
    {
        private readonly IFuncionarioRepository _repository;
        public CreateFuncionarioUseCase(IFuncionarioRepository repository)
        {
            _repository = repository;
        }
        public async Task ExecuteAsync(FuncionarioDto dto)
        {
            var funcionario = new Departamentos.Domain.Entities.Funcionario
            {
                Nome = dto.Nome,
                Foto = dto.Foto,
                RG = dto.RG,
                DepartamentoId = dto.DepartamentoId
            };
            await _repository.AddAsync(funcionario);
        }
    }
}