using Departamentos.Application.Dtos;
using Departamentos.Domain.Entities;
using Departamentos.Domain.Interfaces;
using System.Threading.Tasks;

namespace Departamentos.Application.UseCases.Departamento
{
    public class CreateDepartamentoUseCase
    {
        private readonly IDepartamentoRepository _repository;
        public CreateDepartamentoUseCase(IDepartamentoRepository repository)
        {
            _repository = repository;
        }
        public async Task ExecuteAsync(DepartamentoDto dto)
        {
            var departamento = new Departamentos.Domain.Entities.Departamento
            {
                Nome = dto.Nome,
                Sigla = dto.Sigla
            };
            await _repository.AddAsync(departamento);
        }
    }
}